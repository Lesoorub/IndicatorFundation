using IndicatorFundation.Core.Frames;

namespace Frames.MainFrame;

public partial class MainFrame
{
    /// <summary>
    /// Auto generated
    /// </summary>
    public class Model : IFrameModel
    {
        private bool _name;
        public bool name 
        { 
            get => this._name; 
            set 
            {
                this._name = value;
                this.name_Changed?.Invoke(this._name);
            } 
        }
        public event Action<bool>? name_Changed;
    }
}