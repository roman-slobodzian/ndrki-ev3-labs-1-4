namespace Ev3Labs;

internal static class Program
{
    private static async Task<int> Main()
    {
        using var cancellation = new CancellationTokenSource();
        Console.CancelKeyPress += (_, eventArgs) =>
        {
            eventArgs.Cancel = true;
            cancellation.Cancel();
        };

        try
        {
            await using var robot = new Ev3Robot();

            Console.WriteLine("Connecting to EV3 over USB...");
            await robot.ConnectAsync(cancellation.Token);
            Console.WriteLine("Connected. Hold touch sensor 1 to drive; press Q or Ctrl+C to exit.");

            var driving = false;
            while (true)
            {
                if (StopRequested(cancellation.Token)) return 0;

                var pressed = await robot.TouchPressedAsync(cancellation.Token);
                if (pressed)
                {
                    await robot.DriveForwardAsync(cancellation.Token);
                    if (!driving)
                    {
                        Console.WriteLine("Pressed: driving forward.");
                    }
                }
                else if (driving)
                {
                    await robot.StopAsync(cancellation.Token);
                    Console.WriteLine("Released: stopped.");
                }

                driving = pressed;
                await Task.Delay(50, cancellation.Token);
            }
        }
        catch (OperationCanceledException)
        {
            return 0;
        }
        catch (Exception exception)
        {
            Console.Error.WriteLine($"Error: {exception.Message}");
            return 1;
        }
    }

    private static bool StopRequested(CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();
        if (Console.IsInputRedirected || !Console.KeyAvailable) return false;
        return Console.ReadKey(intercept: true).Key is ConsoleKey.Q or ConsoleKey.Escape;
    }
}
