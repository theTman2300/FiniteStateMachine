using UnityEngine;
using UnityEngine.Events;

public class TriggerZone : MonoBehaviour
{
    [SerializeField] UnityEvent OnEnterTrigger = new();
    [SerializeField] UnityEvent OnExitTrigger = new();

    private void OnTriggerEnter(Collider other)
    {
        OnEnterTrigger.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        OnExitTrigger.Invoke();
    }
}
