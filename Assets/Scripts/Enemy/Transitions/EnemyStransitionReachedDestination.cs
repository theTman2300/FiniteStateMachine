using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "EnemyReachedDestination", menuName = "ScriptableObjects/Enemy/Transitions/EnemyReachedDestination")]
public class EnemyStransitionReachedDestination : Transition
{
    NavMeshAgent Enemy;

    public override void Start()
    {
        base.Start();
        Enemy = GameObject.FindWithTag("Enemy").GetComponent<NavMeshAgent>();
    }

    protected override bool ShouldTransition()
    {
        if (!Enemy.hasPath)
            return true;
        return false;
    }
}
