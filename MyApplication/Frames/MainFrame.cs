using IndicatorFundation.Core.Frames;
using IndicatorFundation.Core.Graphics;

namespace Frames.MainFrame;

public partial class MainFrame : Frame
{
    public MainFrame(IGraphicDriver graphicDriver, IGraphicFrame graphicFrame) 
        : base(graphicDriver, graphicFrame)
    {
        this.present = new Lazy<FramePresent>(() => new Present(this));
        this.logic = new Lazy<FrameLogic>(() => new Logic(this));
        this.model = new Lazy<IFrameModel>(() => new Model());
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