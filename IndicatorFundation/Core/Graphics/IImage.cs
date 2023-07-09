namespace IndicatorFundation.Core.Graphics;

public interface IImage
{
    void Draw();

    void LoadFrom(string file);
    void LoadFrom(byte[] bytes);
}
