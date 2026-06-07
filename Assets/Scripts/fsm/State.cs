using UnityEngine;

public abstract class State : ScriptableObject
{
    public Transition[] Transitions;

    public virtual void Start()
    {
        foreach (Transition transition in Transitions)
        {
            transition.Start();
        }
    }

    public virtual void Tick()
    {
        foreach (Transition transition in Transitions)
        {
            transition.Tick();
        }
    }

    public virtual void End() { }

}
