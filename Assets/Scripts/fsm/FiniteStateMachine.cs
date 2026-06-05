using UnityEngine;

public class FiniteStateMachine : MonoBehaviour
{
    public State currentState;

    void Start()
    {
        
    }

    void Update()
    {
        currentState.Tick();
    }

    public void TransitionToState(State state)
    {
        currentState = state;
        SubscribeToTransitions(currentState.Transitions);
    }

    void UnsubscribeOldTransitions()
    {

    }

    void SubscribeToTransitions(Transition[] transitions)
    {
        foreach (Transition transition in transitions)
        {
            transition.OnTransition.AddListener(TransitionToState);
        }
    }
}
