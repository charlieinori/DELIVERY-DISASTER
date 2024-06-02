using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public Transform targetObject; 
    public Vector3 offset; 
    public float followSpeed = 5f; 

    void LateUpdate()
    {
        if (targetObject != null)
        {
            
            Vector3 desiredPosition = targetObject.position - targetObject.forward * offset.z + Vector3.up * offset.y;

           
            transform.position = Vector3.Lerp(transform.position, desiredPosition, followSpeed * Time.deltaTime);

           
            transform.LookAt(targetObject.position + Vector3.up * offset.y);
        }
    }
}
