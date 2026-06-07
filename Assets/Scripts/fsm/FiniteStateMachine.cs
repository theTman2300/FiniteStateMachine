using UnityEngine;

public class FiniteStateMachine : MonoBehaviour
{
    public State currentState;

    private void Start()
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

    void StateStart()
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
