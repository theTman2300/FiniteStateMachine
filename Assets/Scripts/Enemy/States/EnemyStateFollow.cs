using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "Follow", menuName = "ScriptableObjects/Enemy/States/Follow")]
public class EnemyStateFollow : State
{
    NavMeshAgent Enemy;
    Transform Player;

    public override void Start()
    {
        base.Start();
        Enemy = GameObject.FindWithTag("Enemy").GetComponent<NavMeshAgent>();
        Player = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }

    public override void Tick()
    {
        base.Tick();
        Enemy.SetDestination(Player.position);
    }
}
