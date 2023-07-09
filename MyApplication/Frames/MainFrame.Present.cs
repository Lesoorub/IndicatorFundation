using IndicatorFundation.Core.Frames;
using IndicatorFundation.Core.Graphics;

namespace Frames.MainFrame;

public partial class MainFrame
{
    /// <summary>
    /// Auto generated
    /// </summary>
    public partial class Present : FramePresent
    {
        #region Indicators

        readonly IIndicator SpeedIsZero;

        #endregion

        #region Methods

        public Present(Frame frame) : base(frame)
        {
            this.SpeedIsZero = this.frame.graphicFrame.CreateIndicator(new IndicatorTransform()
            {
                positionX = 100,
                positionY = 100,
                sizeX = 200,
                sizeY = 50,
            }, IndicatorView.backColor);
            this.SpeedIsZero.state = this.SpeedIsZero_Red;

            this.model.name_Changed += this.name_Changed;
        }

        private void Deinit()
        {
            this.model.name_Changed -= this.name_Changed;
        }

        #endregion

        #region States

        #region SpeedIsZero

        IndicatorState SpeedIsZero_Green = new IndicatorState()
        {
            BackColor = 0x00FF00FFu,
        };

        IndicatorState SpeedIsZero_Red = new IndicatorState()
        {
            BackColor = 0xFF0000FFu,
        };

        #endregion

        #endregion

        #region Model handles
        
        private void name_Changed(bool obj)
        {
            this.SpeedIsZero_Changed();
        }

        #endregion

        #region Indicator handlers

        void SpeedIsZero_Changed()
        {
            if (this.model.name)
            {
                this.SpeedIsZero.state = this.SpeedIsZero_Green;
            }
            else
            {
                this.SpeedIsZero.state = this.SpeedIsZero_Red;
            }
        }

        #endregion
    }
}