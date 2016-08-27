using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMotor : MonoBehaviour {
    private Vector3 velocity = Vector3.zero;
    Rigidbody rb;

    private Vector3 rotation = Vector3.zero;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Run every physics iteration
        PerformMovement();
        PerformRotation();
    }

    // Gets a movement Vector
    public void Move(Vector3 _velocity)
    {
        velocity = _velocity;
    }

    public void Rotate(Vector3 _rotation)
    {
        rotation = _rotation;
    }

    private void PerformMovement()
    {
        if (velocity != Vector3.zero) {
            rb.MovePosition(rb.position + velocity*Time.deltaTime);
        }
    }

    private void PerformRotation()
    {
        rb.MoveRotation(rb.rotation * Quaternion.Euler(rotation));
    }
}
