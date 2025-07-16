using ScreenshotBot.Services;
using System;
using System.IO;
using System.Timers;

string outputFolder = Path.Combine(Directory.GetCurrentDirectory(), "Screenshots");
Directory.CreateDirectory(outputFolder);

int intervalSeconds = 10;

Console.WriteLine("🟢 ScreenshotBot avviato.");
Console.WriteLine($"Ogni {intervalSeconds} secondi verrà catturato uno screenshot.");
Console.WriteLine("Premi INVIO per fermare il bot.\n");

System.Timers.Timer timer = new(intervalSeconds * 1000);
timer.Elapsed += (sender, e) => ScreenshotService.CaptureScreenshot(outputFolder);
timer.Start();

Console.ReadLine();

Console.WriteLine("🛑 Bot fermato. Uscita...");
timer.Stop();
timer.Dispose();
