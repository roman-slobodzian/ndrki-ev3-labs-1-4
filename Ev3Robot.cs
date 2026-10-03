namespace Ev3Labs;

internal sealed class Ev3Robot : IAsyncDisposable
{
    private const byte TouchSensorType = 16;
    private const byte LeftMotor = 0x04;  // C
    private const byte RightMotor = 0x02; // B
    private const int LeftSpeed = 20;
    private const int RightSpeed = 20;
    private const int DrivePulseMilliseconds = 300;

    private readonly Ev3UsbConnection _connection = new();
    private bool _connected;

    public async Task ConnectAsync(CancellationToken cancellationToken = default)
    {
        await _connection.ConnectAsync(cancellationToken);

        var sensor = await _connection.ExecuteAsync([
            0x99, 0x05, // opINPUT_DEVICE, GET_TYPEMODE
            0x81, 0x00, // Layer 0
            0x81, 0x00, // Input port 1 (zero based)
            0xE1, 0x00, // Device type -> global byte 0
            0xE1, 0x01  // Mode -> global byte 1
        ], globalBytes: 2, cancellationToken);

        if (sensor[0] != TouchSensorType)
            throw new IOException(
                $"EV3 input port 1 has device type {sensor[0]}; expected touch sensor type {TouchSensorType}.");

        _connected = true;
    }

    public async Task<bool> TouchPressedAsync(CancellationToken cancellationToken = default)
    {
        EnsureConnected();

        var value = await _connection.ExecuteAsync([
            0x9A,       // opINPUT_READ
            0x81, 0x00, // Layer 0
            0x81, 0x00, // Input port 1 (zero based)
            0x81, 0x00, // Keep detected device type
            0x81, 0xFF, // Keep current mode
            0xE1, 0x00  // Value -> global byte 0
        ], globalBytes: 1, cancellationToken);

        if (value[0] == 0x80)
            throw new IOException("Touch sensor 1 is not returning valid data.");

        return value[0] != 0;
    }

    public Task DriveForwardAsync(CancellationToken cancellationToken = default)
    {
        EnsureConnected();

        return _connection.ExecuteWithoutDataAsync([
            0xAF, 0x00, RightMotor, 0x81, unchecked((byte)RightSpeed), // opOUTPUT_TIME_SPEED
            0x83, 0x00, 0x00, 0x00, 0x00,
            0x83, (byte)(DrivePulseMilliseconds & 0xFF), (byte)(DrivePulseMilliseconds >> 8), 0x00, 0x00,
            0x83, 0x00, 0x00, 0x00, 0x00,
            0x81, 0x01,

            0xAF, 0x00, LeftMotor, 0x81, unchecked((byte)LeftSpeed),
            0x83, 0x00, 0x00, 0x00, 0x00,
            0x83, (byte)(DrivePulseMilliseconds & 0xFF), (byte)(DrivePulseMilliseconds >> 8), 0x00, 0x00,
            0x83, 0x00, 0x00, 0x00, 0x00,
            0x81, 0x01
        ], cancellationToken);
    }

    public Task StopAsync(CancellationToken cancellationToken = default)
    {
        if (!_connected) return Task.CompletedTask;

        return _connection.ExecuteWithoutDataAsync([
            0xA3, 0x00, LeftMotor | RightMotor, 0x81, 0x01 // opOUTPUT_STOP, brake
        ], cancellationToken);
    }

    public async ValueTask DisposeAsync()
    {
        if (_connected)
        {
            try
            {
                await StopAsync();
            }
            catch
            {
                // The USB connection may already be gone.
            }
        }

        _connected = false;
        await _connection.DisposeAsync();
    }

    private void EnsureConnected()
    {
        if (!_connected) throw new InvalidOperationException("EV3 is not connected.");
    }
}
