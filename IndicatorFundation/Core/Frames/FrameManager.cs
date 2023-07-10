using System.Diagnostics;
using IndicatorFundation.Core.Graphics;

namespace IndicatorFundation.Core.Frames;
public class FrameManager
{
    public IGraphicDriver driver;
    public FrameManager(IGraphicDriver driver)
    {
        this.driver = driver;
    }

    public void Run<T>(uint width, uint height, string title) where T : Frame
    {
        int targetfps = 60;
        int deltaTime = (int)(1000f / targetfps);
        using (var frame = this.driver.CreateWindow(width, height, title))
        {
            var instance = (T?)Activator.CreateInstance(typeof(T), this.driver, frame);

            if (instance != null)
            {
                var logic = instance.logic;
                while (frame.Visible)
                {
                    var timer = Stopwatch.StartNew();

                    frame.DoEvents();
                    logic.UpdateCoruntines();
                    frame.Draw();

                    timer.Stop();
                    Thread.Sleep(Math.Max(0, deltaTime - (int)timer.ElapsedMilliseconds));
                }
                if (instance is IDisposable disposable)
                    disposable.Dispose();
            }
        }
    }
}
