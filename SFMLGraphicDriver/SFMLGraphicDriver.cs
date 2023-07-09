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

    public void DrawFilledRect(int x, int y, int sizeX, int sizeY, uint color = 0xFFFFFFFFu)
    {
        throw new NotImplementedException();
    }

    public void DrawImage(int x, int y, int sizeX, int sizeY)
    {
        throw new NotImplementedException();
    }

    public void DrawLine(int x1, int y1, int x2, int y2, uint color = 0xFFFFFFFFu)
    {
        throw new NotImplementedException();
    }

    public void DrawLines(int[] points, uint color = 0xFFFFFFFFu)
    {
        throw new NotImplementedException();
    }

    public void DrawLinesStrip(int[] points, uint color = 0xFFFFFFFFu)
    {
        throw new NotImplementedException();
    }

    public void DrawRect(int x, int y, int sizeX, int sizeY, uint color = 0xFFFFFFFFu)
    {
        throw new NotImplementedException();
    }

    public void DrawText(string text, int x, int y, int sizeX, int sizeY)
    {
        throw new NotImplementedException();
    }
}
