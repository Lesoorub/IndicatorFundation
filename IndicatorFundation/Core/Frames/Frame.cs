using IndicatorFundation.Core.Graphics;

namespace IndicatorFundation.Core.Frames;

public abstract class Frame
{
    public bool Visible => this.graphicFrame.Visible;
    public Lazy<FramePresent> present = new Lazy<FramePresent>();
    public Lazy<FrameLogic> logic = new Lazy<FrameLogic>();
    public Lazy<IFrameModel> model = new Lazy<IFrameModel>();

    public readonly IGraphicDriver graphicDriver;
    public readonly IGraphicFrame graphicFrame;

    public Frame(IGraphicDriver graphicDriver, IGraphicFrame graphicFrame)
    {
        this.graphicDriver = graphicDriver;
        this.graphicFrame = graphicFrame;
    }
}
