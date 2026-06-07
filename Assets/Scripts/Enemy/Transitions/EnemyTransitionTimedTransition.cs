using UnityEngine;

[CreateAssetMenu(fileName = "TimedTransition", menuName = "ScriptableObjects/Enemy/Transitions/TimedTransition")]
public class EnemyTransitionTimedTransition : Transition
{
    [SerializeField] float timeSeconds;

    float timer;

    public override void Start()
    {
        base.Start();
        timer = 0;
    }

    protected override bool ShouldTransition()
    {
        timer += Time.deltaTime;
        if (timer > timeSeconds)
            return true;
        return false;
    }
}
