using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "Wander", menuName = "ScriptableObjects/Enemy/States/Wander")]
public class EnemyStateWander : State
{
    [SerializeField] float maxWanderDistance;
    [SerializeField] float wanderIntervalSeconds;

    float timer = 0;
    bool isWandering = false;
    NavMeshAgent Enemy;

    public override void Start()
    {
        base.Start();
        Enemy = GameObject.FindWithTag("Enemy").GetComponent<NavMeshAgent>();
    }

    public override void Tick()
    {
        base.Tick();
        timer += Time.deltaTime;
    }

    void RandomWander()
    {
        isWandering = true;
    }
}
