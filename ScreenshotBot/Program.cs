using ScreenshotBot.Services;
using System.Timers;
using System.Threading;
using System.IO;
using System;

string outputFolder = Path.Combine(AppContext.BaseDirectory, "Screenshots");
Directory.CreateDirectory(outputFolder);

int intervalSeconds = 10;

System.Timers.Timer timer = new(intervalSeconds * 1000);
timer.Elapsed += (sender, e) => ScreenshotService.CaptureScreenshot(outputFolder);
timer.Start();

// Blocca il processo finché non viene terminato esternamente (es. Task Manager)
var quitEvent = new ManualResetEvent(false);
quitEvent.WaitOne();
