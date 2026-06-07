using UnityEngine;

[CreateAssetMenu(fileName = "PlayerMovedAway", menuName = "ScriptableObjects/Enemy/Transitions/PlayerMovedAway")]
public class EnemyTransitionPlayerMovedAway : Transition
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
        if (Vector3.Distance(Player.position, Enemy.transform.position) < distance)
            return false;

        return true;
    }
}
