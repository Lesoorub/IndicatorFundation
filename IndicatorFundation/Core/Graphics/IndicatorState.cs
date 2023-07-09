namespace IndicatorFundation.Core.Graphics;

public struct IndicatorState
{
    public bool Visible { get; set; }
    public uint BackColor { get; set; }
    public uint ForeColor { get; set; }
    public Lazy<IImage> BackImage { get; set; }
    public Func<string> DisplayText { get; set; }
}
