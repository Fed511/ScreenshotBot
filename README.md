# ScreenshotBot
# ScreenshotBot

ScreenshotBot is a lightweight C# console application that runs silently in the background and captures full-screen screenshots at regular intervals.

## Features

- Runs without showing any visible console window
- Automatically takes screenshots every few seconds
- Saves images in a `Screenshots/` folder with timestamped filenames
- Compiled as a single executable (`.exe`) with no dependencies

## Requirements

- Windows OS
- .NET 8 SDK (for building)
- No installation required to run the published `.exe`

## Usage

1. Build or publish the project:
   ```bash
   dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true
