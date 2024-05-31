using UnityEngine;

public class TeleportToTarget : MonoBehaviour
{
    public Transform target; // Assign the target in the Unity Editor
    public float teleportDistance = 1000f; // Distance to teleport the object far away

    private Vector3 originalPosition;

    void Start()
    {
        // Save the original position of the GameObject
        originalPosition = transform.position;
    }

    void Update()
    {
        // Check if the W key is pressed
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (target != null)
            {
                // Teleport the GameObject to the target's position
                transform.position = target.position;
            }
            else
            {
                Debug.LogError("Target is not assigned. Please assign a target in the Inspector.");
            }
        }

        // Check if the W key is released
        if (Input.GetKeyUp(KeyCode.W))
        {
            // Teleport the GameObject far away
            transform.position = originalPosition + Vector3.up * teleportDistance * 20f;
        }
    }
}
