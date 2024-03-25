using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public Transform targetObject; // Reference to the object the camera will follow
    public Vector3 offset; // Offset from the target object position (for adjusting camera position)
    public float followSpeed = 5f; // Speed at which the camera follows the target

    void LateUpdate()
    {
        if (targetObject != null)
        {
            // Calculate the desired camera position behind the target object
            Vector3 desiredPosition = targetObject.position - targetObject.forward * offset.z + Vector3.up * offset.y;

            // Smoothly move the camera towards the desired position
            transform.position = Vector3.Lerp(transform.position, desiredPosition, followSpeed * Time.deltaTime);

            // Keep the camera looking at the target object while ignoring tilt
            transform.LookAt(targetObject.position + Vector3.up * offset.y);
        }
    }
}
