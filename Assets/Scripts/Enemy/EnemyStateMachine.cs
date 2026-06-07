using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;

[RequireComponent (typeof(NavMeshAgent))]
public class EnemyStateMachine : FiniteStateMachine
{
    [SerializeField] float speed;

    protected override void Start()
    {
        base.Start();
        GetComponent<NavMeshAgent>().speed = speed;
    }
}
