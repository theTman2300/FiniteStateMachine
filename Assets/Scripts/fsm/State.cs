using UnityEngine;

public abstract class State
{
    public Transition[] Transitions;
    private FiniteStateMachine fsm;

    public abstract void Tick();

    public void SetFSMreference(FiniteStateMachine newFSM)
    {
        fsm = newFSM;
    }
}
