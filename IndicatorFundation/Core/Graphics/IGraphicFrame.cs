namespace IndicatorFundation.Core.Graphics;

public delegate void KeyEventHandler(int keycode);
public interface IGraphicFrame : IDisposable
{
    bool Visible { get; set; }

    event KeyEventHandler? OnKeyDown;
    event KeyEventHandler? OnKeyUp;

    IEnumerable<IIndicator> Indicators { get; }

    IIndicator CreateIndicator(IndicatorTransform transform, IndicatorView view);

    void DoEvents();
    void Draw();

    void Close();
}
