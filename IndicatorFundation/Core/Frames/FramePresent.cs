namespace IndicatorFundation.Core.Frames;

public abstract class FramePresent : IDisposable
{
    protected Frame frame;
    public IFrameModel model => this.frame.model.Value;
    public FramePresent(Frame frame)
    {
        this.frame = frame;
    }
    public virtual void Dispose() { }
}
