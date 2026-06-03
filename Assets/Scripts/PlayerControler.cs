using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControler : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float acceleration;

    Rigidbody rb;
    Vector2 moveInput;
    Vector2 lastMoveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (rb.linearVelocity.magnitude < speed)
        {
            rb.AddForce(new Vector3(moveInput.x, 0, moveInput.y) * Time.deltaTime * 1000 * acceleration);
        }

        if (moveInput != Vector2.zero) 
            lastMoveInput = moveInput;
        if (lastMoveInput != Vector2.zero)
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(new Vector3(lastMoveInput.x, 0, lastMoveInput.y)), 0.126f);
    }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
}
