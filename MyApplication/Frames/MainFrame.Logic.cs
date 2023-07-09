using System.Collections;
using IndicatorFundation.Core.Frames;
using static Frames.MainFrame.MainFrame;

namespace Frames.MainFrame;

public partial class MainFrame
{
    /// <summary>
    /// Will never generate code
    /// </summary>
    public class Logic : FrameLogic
    {
        Model model => (Model)this.frame.model.Value;
        public Logic(Frame frame) : base(frame)
        {
            base.Start(this.Timer());
        }

        public IEnumerator Timer()
        {
            while (this.frame.Visible)
            {
                this.model.name = !this.model.name;
                yield return new WaitTime(1000);
            }
            yield break;
        }
    }
}