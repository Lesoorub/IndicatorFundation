using IndicatorFundation.Core.Graphics;
using SFML.Graphics;
using SFML.Window;

namespace SFML.GraphicDriver;

public class Window : IGraphicFrame
{
    readonly RenderWindow window;
    bool visible = true;
    List<Indicator> indicators = new List<Indicator>();
    public LinkedList<Drawable> drawables = new LinkedList<Drawable>();

    public Window(uint width, uint height, string title)
    {
        this.window = new RenderWindow(new VideoMode(width, height), title);
        this.window.Closed += this.Window_Closed;
    }

    private void Window_Closed(object? sender, EventArgs e)
    {
        this.window.Close();
        this.visible = false;
    }

    public IEnumerable<IIndicator> Indicators => this.indicators;
    public bool Visible { get => this.visible; set => this.visible = value; }

    public event KeyEventHandler? OnKeyDown;
    public event KeyEventHandler? OnKeyUp;

    public IIndicator CreateIndicator(IndicatorTransform transform, IndicatorView view)
    {
        return new Indicator(transform, view, ref this.drawables);
    }

    public void DoEvents()
    {
        this.window.DispatchEvents();
    }

    public void Draw()
    {
        this.window.Clear();
        // draw indicators
        foreach (var drawable in this.drawables)
        {
            this.window.Draw(drawable);
        }
        this.window.Display();
    }

    public void Dispose()
    {
        foreach (var indicator in this.indicators)
            indicator.Dispose();
        this.window.Dispose();
    }

}
