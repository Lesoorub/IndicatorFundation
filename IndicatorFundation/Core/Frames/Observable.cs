namespace IndicatorFundation.Core.Frames;

public class Observable<T> where T : struct
{
    T? value;
    public T? Value
    {
        get => this.value;
        set
        {
            this.value = value;
            this.OnChange?.Invoke(value);
        }
    }
    public delegate void OnChangeEventHandler(T? newValue);
    public event OnChangeEventHandler? OnChange;
    public Observable()
    {
        this.value = default(T);
    }
    public Observable(T @default)
    {
        this.value = @default;
    }
}