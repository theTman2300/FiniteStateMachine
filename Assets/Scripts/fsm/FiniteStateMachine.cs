using UnityEngine;

public class FiniteStateMachine : MonoBehaviour
{
    public State currentState;

    protected virtual void Start()
    {
        StateStart();
    }

    void Update()
    {
        currentState.Tick();
    }

    public void TransitionToState(State state)
    {
        currentState.End();
        currentState = state;
        StateStart();
    }

    protected virtual void StateStart()
    {
        currentState.Start();
        SubscribeToTransitions(currentState.Transitions);
    }

    void SubscribeToTransitions(Transition[] transitions)
    {
        foreach (Transition transition in transitions)
        {
            transition.OnTransition.AddListener(TransitionToState);
        }
    }
}
