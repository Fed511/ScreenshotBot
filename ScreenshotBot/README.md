# ScreenshotBot

A simple C# console application that takes full-screen screenshots at regular intervals.

## Features

- Automatically captures screenshots every X seconds  
- Saves images to a `Screenshots` folder with timestamped filenames  
- Runs in the background until stopped manually

## Requirements

- .NET 8.0 (Windows)  
- Windows OS (due to use of System.Windows.Forms)

## How to Use

1. Build and run the project  
2. Screenshots will be saved in the `Screenshots` folder  
3. Press `Enter` to stop the application

## Notes

- Make sure the target framework in your `.csproj` is set to `net8.0-windows`  
- Windows Forms must be enabled in the project file

---

