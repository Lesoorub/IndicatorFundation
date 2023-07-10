using IndicatorFundation.Core.Graphics;

namespace SFML.GraphicDriver;

public class SFMLGraphicDriver : IGraphicDriver
{
    public IGraphicFrame CreateWindow(uint width, uint height, string title)
    {
        return new Window(width, height, title);
    }

    public void Dispose()
    {
    }
}
