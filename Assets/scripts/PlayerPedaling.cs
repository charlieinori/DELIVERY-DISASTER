using UnityEngine;

public class PlayerPedaling : MonoBehaviour
{
    public float pedalForce = 5f; // Adjust this to set the force applied by pedaling
    public float maxSpeed = 10f; // Adjust this to set the maximum speed
    public float rotationSpeed = 5f; // Adjust this to set the rotation speed
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Get input
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        // Calculate force based on input
        Vector3 forwardVelocity = transform.forward * rb.velocity.magnitude;
        Vector3 pedalForceVector = (transform.right * horizontalInput * pedalForce) + forwardVelocity;

        // Limit speed
        rb.velocity = Vector3.ClampMagnitude(pedalForceVector, maxSpeed);

        // Mouse control
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            Vector3 targetDirection = hit.point - transform.position;
            targetDirection.y = 0f; // Keep the direction horizontal
            Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
}