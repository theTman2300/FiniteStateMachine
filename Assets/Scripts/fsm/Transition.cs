using UnityEngine;
using UnityEngine.Events;

public abstract class Transition
{
    State toState;
    public UnityEvent<State> OnTransition;

    public abstract void Tick();

    public virtual void CheckShouldTransition()
    {
        OnTransition.Invoke(toState);
    }
}
