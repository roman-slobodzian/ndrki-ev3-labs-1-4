using System.Buffers.Binary;
using HidSharp;

namespace Ev3Labs;

internal sealed class Ev3UsbConnection : IAsyncDisposable
{
    private const int VendorId = 0x0694;
    private const int ProductId = 0x0005;
    private const byte DirectCommandWithReply = 0x00;
    private const byte DirectReply = 0x02;

    private readonly SemaphoreSlim _commandLock = new(1, 1);
    private HidStream? _stream;
    private byte[]? _input;
    private byte[]? _output;
    private ushort _messageId;

    public Task ConnectAsync(CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();
        if (_stream is not null) return Task.CompletedTask;

        var device = DeviceList.Local.GetHidDeviceOrNull(VendorId, ProductId)
            ?? throw new IOException(
                "EV3 USB device not found. Turn on the brick, reconnect its PC cable, and allow Input Monitoring.");

        var configuration = new OpenConfiguration();
        configuration.SetOption(OpenOption.Exclusive, false);

        _stream = device.Open(configuration);
        _input = new byte[device.GetMaxInputReportLength()];
        _output = new byte[device.GetMaxOutputReportLength()];

        return Task.CompletedTask;
    }

    public async Task<byte[]> ExecuteAsync(
        byte[] bytecode,
        ushort globalBytes,
        CancellationToken cancellationToken = default)
    {
        var stream = _stream ?? throw new InvalidOperationException("EV3 USB connection is not open.");
        var input = _input!;
        var output = _output!;

        await _commandLock.WaitAsync(cancellationToken);
        try
        {
            Array.Clear(output);
            Array.Clear(input);

            var messageId = NextMessageId();
            var commandSize = checked((ushort)(5 + bytecode.Length));

            BinaryPrimitives.WriteUInt16LittleEndian(output.AsSpan(1), commandSize);
            BinaryPrimitives.WriteUInt16LittleEndian(output.AsSpan(3), messageId);
            output[5] = DirectCommandWithReply;
            output[6] = (byte)globalBytes;
            output[7] = (byte)(globalBytes >> 8);
            bytecode.CopyTo(output, 8);

            await stream.WriteAsync(output, 0, output.Length, cancellationToken);
            await stream.FlushAsync(cancellationToken);
            await stream.ReadExactlyAsync(input, 0, input.Length, cancellationToken);

            var replySize = BinaryPrimitives.ReadUInt16LittleEndian(input.AsSpan(1));
            var replyId = BinaryPrimitives.ReadUInt16LittleEndian(input.AsSpan(3));
            if (replySize < 3 || replyId != messageId || input[5] != DirectReply)
                throw new IOException("EV3 returned an invalid direct-command reply.");

            var returnedBytes = replySize - 3;
            if (returnedBytes < globalBytes)
                throw new IOException("EV3 returned less data than requested.");

            return input.AsSpan(6, globalBytes).ToArray();
        }
        finally
        {
            _commandLock.Release();
        }
    }

    public async Task ExecuteWithoutDataAsync(
        byte[] bytecode,
        CancellationToken cancellationToken = default)
    {
        await ExecuteAsync(bytecode, globalBytes: 0, cancellationToken);
    }

    public ValueTask DisposeAsync()
    {
        _stream?.Dispose();
        _stream = null;
        _input = null;
        _output = null;
        _commandLock.Dispose();
        return ValueTask.CompletedTask;
    }

    private ushort NextMessageId()
    {
        _messageId++;
        if (_messageId == 0) _messageId++;
        return _messageId;
    }
}
