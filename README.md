# EV3 Touch Drive

A small C#/.NET lab application that controls an EV3 robot from macOS over USB. The robot moves forward only while the touch sensor is pressed.

## Hardware

Connect the touch sensor to input port **1**, the left motor to output port **C**, and the right motor to output port **B**. Turn on the EV3 brick and connect it to the Mac with a USB data cable. Keep the standard EV3 firmware running; this application runs on the Mac and sends commands to the brick.

## Run

The project requires the .NET 10 SDK. On macOS, allow the terminal or IDE under **System Settings → Privacy & Security → Input Monitoring**, then restart that application.

```bash
dotnet restore
dotnet build
dotnet run
```

Press and hold the touch sensor to drive forward. Release it to stop. Press **Q**, **Esc**, or **Ctrl+C** to exit.

For the architecture and full verification procedure, see [report.md](report.md).
