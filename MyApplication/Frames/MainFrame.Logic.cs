using System.Collections;
using IndicatorFundation.Core.Frames;

namespace Frames.MainFrame;

public partial class MainFrame
{
    /// <summary>
    /// Will never generate code
    /// </summary>
    public class Logic : FrameLogic
    {
        Model model => (Model)this.frame.model;
        public Logic(Frame frame) : base(frame)
        {
            base.Start(this.Cycle());
        }

        public IEnumerator Cycle()
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