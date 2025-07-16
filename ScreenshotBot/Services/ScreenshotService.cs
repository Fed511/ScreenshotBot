using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ScreenshotBot.Services
{
    public static class ScreenshotService
    {
        public static void CaptureScreenshot(string outputDir)
        {
            Rectangle bounds = Screen.PrimaryScreen.Bounds;

            using Bitmap bitmap = new(bounds.Width, bounds.Height);
            using Graphics g = Graphics.FromImage(bitmap);
            g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);

            string filename = $"screenshot_{DateTime.Now:yyyyMMdd_HHmmss}.png";
            string path = Path.Combine(outputDir, filename);

            bitmap.Save(path, ImageFormat.Png);

            Console.WriteLine($"[✔] Screenshot salvato: {filename}");
        }
    }
}
