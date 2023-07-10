using IndicatorFundation.Core.Frames;
using IndicatorFundation.Core.Graphics;

namespace Frames.MainFrame;

public partial class MainFrame : Frame
{
    public MainFrame(IGraphicDriver graphicDriver, IGraphicFrame graphicFrame) 
        : base(graphicDriver, graphicFrame)
    {
        this.model = new Model();
        this.present = new Present(this);
        this.logic = new Logic(this);
    }

    public partial class Present : FramePresent
    {
        new Model model => (Model)base.model;

        public override void Dispose()
        {
            this.Deinit();
            base.Dispose();
        }
    }
}