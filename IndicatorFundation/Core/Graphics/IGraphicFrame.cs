namespace IndicatorFundation.Core.Graphics;

public delegate void KeyEventHandler(int keycode);
public interface IGraphicFrame : IDisposable
{
    bool Visible { get; set; }

    event KeyEventHandler? OnKeyDown;
    event KeyEventHandler? OnKeyUp;

    IEnumerable<IIndicator> Indicators { get; }

    IIndicator CreateIndicator(IndicatorTransform transform, IndicatorView mask);

    void DoEvents();
    void Draw();

    IText CreateText(string text, int x, int y, int sizeX, int sizeY);
    IImage CreateImage(int x, int y, int sizeX, int sizeY);
    IRect CreateRect(int x, int y, int sizeX, int sizeY, uint color = 0xFFFFFFFFu);
    ILine CreateLine(int x1, int y1, int x2, int y2, uint color = 0xFFFFFFFFu);
    ILines CreateLines(int[] points, uint color = 0xFFFFFFFFu);
    ILinesStrip CreateLinesStrip(int[] points, uint color = 0xFFFFFFFFu);
}
public interface IText
{
    string DisplayString { get; set; }
}
public interface IRect
{
    
}
public interface ILine
{

}
public interface ILines
{

}
public interface ILinesStrip 
{

}