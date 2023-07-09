using System;
using System.Collections;

namespace IndicatorFundation.Core.Frames;
public abstract class FrameLogic
{
    protected Frame frame;
    LinkedList<Coruntine> coruntines = new LinkedList<Coruntine>();

    public FrameLogic(Frame frame)
    {
        this.frame = frame;
    }
    public void Start(IEnumerator coruntine)
    {
        this.coruntines.AddLast(new Coruntine(coruntine));
    }

    public void UpdateCoruntines()
    {
        Queue<Coruntine>? remove = null;
        foreach (var coruntine in this.coruntines)
        {
            if ((coruntine.Current == null ||
                coruntine.Current is WaitTime waitTime &&
                waitTime.StartTime <= DateTime.Now) && !coruntine.MoveNext())
            {
                if (remove == null)
                    remove = new Queue<Coruntine>();
                remove.Enqueue(coruntine);
            }
        }
        if (remove != null)
        {
            foreach (var coruntine in remove)
            {
                this.coruntines.Remove(coruntine);
            }
        }
    }
}

public class Coruntine 
{
    IEnumerator coruntine;
    public object Current => this.coruntine.Current;

    public Coruntine(IEnumerator coruntine) 
    {
        this.coruntine = coruntine;
        this.MoveNext();
    }

    public bool MoveNext()
    {
        return this.coruntine.MoveNext();
    }
}


public class WaitTime
{
    public DateTime StartTime;
    public WaitTime(int milliseconds)
    {
        this.StartTime = DateTime.Now + new TimeSpan(0, 0, 0, 0, milliseconds);
    }
}