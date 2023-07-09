using IndicatorFundation.Core.Graphics;
using SFML.Graphics;
using SFML.System;

namespace SFML.GraphicDriver;

public class Indicator : IIndicator
{
    private IndicatorState m_state;
    private IndicatorTransform m_transform;

    public IndicatorState state { get => this.m_state; set { this.m_state = value; this.OnStateChanged(); } }
    public IndicatorTransform transform { get => this.m_transform; set => this.m_transform = value; }

    public IndicatorView m_view;
    public IndicatorView view => this.m_view;

    public Lazy<Text> m_text = new Lazy<Text>(() => new Text());
    public Lazy<RectangleShape> m_backrect = new Lazy<RectangleShape>(() => new RectangleShape());

    public LinkedList<Drawable> drawables;

    public Indicator(IndicatorTransform transform, IndicatorView view, ref LinkedList<Drawable> drawables)
    {
        this.transform = transform;
        this.m_view = view;
        this.drawables = drawables;

        if (this.m_view.HasFlag(IndicatorView.text))
        {
            this.drawables.AddLast(this.m_text.Value);
        }

        if (this.m_view.HasFlag(IndicatorView.backColor))
        {
            this.drawables.AddLast(this.m_backrect.Value);
        }
    }

    public void OnStateChanged()
    {
        if (this.m_view.HasFlag(IndicatorView.text))
        {
            var text = this.m_text.Value;
            text.Position = new Vector2f(this.transform.positionX, this.transform.positionY);
            text.DisplayedString = this.state.DisplayText?.Invoke();
        }

        if (this.m_view.HasFlag(IndicatorView.backColor))
        {
            var rect = this.m_backrect.Value;
            rect.Position = new Vector2f(this.transform.positionX, this.transform.positionY);
            rect.Size = new Vector2f(this.transform.sizeX, this.transform.sizeY);
            rect.FillColor = new Color(this.m_state.BackColor);
        }
    }

    public void Dispose()
    {
        if (this.m_text.IsValueCreated)
            this.m_text.Value.Dispose();
        if (this.m_backrect.IsValueCreated)
            this.m_backrect.Value.Dispose();
    }
}