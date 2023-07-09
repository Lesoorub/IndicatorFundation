namespace IndicatorFundation.Core.Graphics;

public interface IGraphicDriver : IDisposable
{
    IGraphicFrame CreateWindow(uint width, uint height, string title);
    void DrawText(string text, int x, int y, int sizeX, int sizeY);
    void DrawImage(int x, int y, int sizeX, int sizeY);
    void DrawFilledRect(int x, int y, int sizeX, int sizeY, uint color = 0xFFFFFFFFu);
    void DrawRect(int x, int y, int sizeX, int sizeY, uint color = 0xFFFFFFFFu);
    void DrawLine(int x1, int y1, int x2, int y2, uint color = 0xFFFFFFFFu);
    void DrawLines(int[] points, uint color = 0xFFFFFFFFu);
    void DrawLinesStrip(int[] points, uint color = 0xFFFFFFFFu);
}
