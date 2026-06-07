using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "Wander", menuName = "ScriptableObjects/Enemy/States/Wander")]
public class EnemyStateWander : State
{
    [SerializeField] float maxWanderDistance;
    [SerializeField] float wanderIntervalSeconds;
    [SerializeField] float speed;

    float timer = 0;
    NavMeshAgent Enemy;

    public override void Start()
    {
        base.Start();
        timer = 0;
        Enemy = GameObject.FindWithTag("Enemy").GetComponent<NavMeshAgent>();
        Enemy.speed = speed;
        RandomWander();
    }

    public override void Tick()
    {
        base.Tick();

        if (Enemy.hasPath) return;
        timer += Time.deltaTime;
        if (timer > wanderIntervalSeconds)
        {
            timer = 0;
            RandomWander();
        }
    }

    void RandomWander()
    {
        RaycastHit hit;
        Vector3 randomDirection = new(Random.value * 2 - 1, 0, Random.value * 2 - 1);
        randomDirection.Normalize();
        if (Physics.Raycast(Enemy.transform.position, randomDirection, out hit, maxWanderDistance))
        {
            Enemy.SetDestination(hit.point);
        }
        else
        {
            Enemy.SetDestination(randomDirection * maxWanderDistance +Enemy.transform.position);
        }

    }

    public override void End()
    {
        base.End();
        Enemy.ResetPath();
    }
}
