using IndicatorFundation.Core.Graphics;

namespace IndicatorFundation.Core.Frames;

public abstract class Frame
{
    public bool Visible => this.graphicFrame.Visible;
    public FramePresent present = null!;
    public FrameLogic logic = null!;
    public IFrameModel model = null!;

    public readonly IGraphicDriver graphicDriver;
    public readonly IGraphicFrame graphicFrame;

    public Frame(IGraphicDriver graphicDriver, IGraphicFrame graphicFrame)
    {
        this.graphicDriver = graphicDriver;
        this.graphicFrame = graphicFrame;
    }
}
