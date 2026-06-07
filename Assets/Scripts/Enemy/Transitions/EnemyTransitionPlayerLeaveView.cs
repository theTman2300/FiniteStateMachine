using UnityEngine;

[CreateAssetMenu(fileName = "PlayerLeaveView",menuName = "ScriptableObjects/Enemy/Transitions/PlayerLeaveView")]
public class EnemyTransitionPlayerLeaveView : Transition
{
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
        RaycastHit hit;
        Physics.Raycast(Enemy.position, (Player.position - Enemy.position).normalized, out hit);
        if (!hit.collider.CompareTag("Player"))
        {
            return true;
        }
        return false;
    }
}
