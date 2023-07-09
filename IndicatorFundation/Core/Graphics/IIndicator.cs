namespace IndicatorFundation.Core.Graphics;

public interface IIndicator : IDisposable
{
    IndicatorView view { get; }
    IndicatorState state { get; set; }
    IndicatorTransform transform { get; set; }
}
