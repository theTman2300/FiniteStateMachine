using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "Search", menuName = "ScriptableObjects/Enemy/States/Search")]
public class EnemyStateSeach : State
{
    [SerializeField] float speed;
    NavMeshAgent Enemy;
    Transform Player;

    public override void Start()
    {
        base.Start();
        Enemy = GameObject.FindWithTag("Enemy").GetComponent<NavMeshAgent>();
        Player = GameObject.FindWithTag("Player").GetComponent<Transform>();
        Enemy.SetDestination(Player.position);
        Enemy.speed = speed;
    }
}
