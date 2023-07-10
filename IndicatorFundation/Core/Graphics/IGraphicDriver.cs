namespace IndicatorFundation.Core.Graphics;

public interface IGraphicDriver : IDisposable
{
    IGraphicFrame CreateWindow(uint width, uint height);
}
