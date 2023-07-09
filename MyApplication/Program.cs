using Frames.MainFrame;
using IndicatorFundation.Core.Frames;
using SFML.GraphicDriver;

using (var driver = new SFMLGraphicDriver())
{
    var fm = new FrameManager(driver);
    fm.Run<MainFrame>(800, 600, "title");
}