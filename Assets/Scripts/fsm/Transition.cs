using UnityEngine;
using UnityEngine.Events;

public abstract class Transition : ScriptableObject
{
    [SerializeField] State toState;
    [HideInInspector] public UnityEvent<State> OnTransition;

    public virtual void Start() { }

    public virtual void Tick()
    {
        if (ShouldTransition())
        {
            OnTransition.Invoke(toState);
        }
    }

    protected abstract bool ShouldTransition();
}
