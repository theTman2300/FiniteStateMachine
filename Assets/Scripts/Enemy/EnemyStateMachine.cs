using UnityEngine;
using UnityEngine.AI;
using TMPro;

[RequireComponent (typeof(NavMeshAgent))]
public class EnemyStateMachine : FiniteStateMachine
{
    [SerializeField] float speed;
    [Space]
    [SerializeField] TextMeshProUGUI stateText;

    string stateTextFormat = "{0}";


    protected override void Start()
    {
        GetComponent<NavMeshAgent>().speed = speed;
        stateTextFormat = stateText.text;
        stateText.text = string.Format(stateTextFormat, currentState.name);
        base.Start();
    }

    protected override void StateStart()
    {
        base.StateStart();
        stateText.text = string.Format(stateTextFormat, currentState.name);
    }
}
