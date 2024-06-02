using UnityEngine;

public class TeleportToTarget : MonoBehaviour
{
    public Transform target; 
    public float teleportDistance = 1000f; 

    private Vector3 originalPosition;

    void Start()
    {
       
        originalPosition = transform.position;
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (target != null)
            {
               
                transform.position = target.position;
            }
            else
            {
                Debug.LogError("Target is not assigned. Please assign a target in the Inspector.");
            }
        }

       
        if (Input.GetKeyUp(KeyCode.W))
        {
            
            transform.position = originalPosition + Vector3.up * teleportDistance * 20f;
        }
    }
}
