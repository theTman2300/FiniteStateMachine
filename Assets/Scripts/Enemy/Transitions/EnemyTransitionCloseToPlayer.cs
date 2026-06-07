using UnityEngine;

[CreateAssetMenu(fileName = "CloseToPlayer", menuName = "ScriptableObjects/Enemy/Transitions/CloseToPlayer")]
public class EnemyTransitionCloseToPlayer : Transition
{
    [Tooltip("The distance from the player at which this will transition")]
    [SerializeField] float distance;

    Transform Enemy;
    Transform Player;

    public override void Start()
    {
        base.Start();
        Enemy = GameObject.FindWithTag("Enemy").GetComponent<Transform>();
        Player = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }

    protected override bool ShouldTransition()
    {
        if (Vector3.Distance(Player.position, Enemy.transform.position) > distance)
            return false;

        RaycastHit hit;
        Physics.Raycast(Enemy.position, (Player.position - Enemy.position).normalized, out hit);
        if (!hit.collider.CompareTag("Player"))
            return false;

        return true;
    }
}
