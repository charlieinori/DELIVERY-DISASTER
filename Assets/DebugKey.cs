using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugKey : MonoBehaviour
{
    public KeyCode debugKeyCode = KeyCode.Space; // The key to trigger the debug log

    void Update()
    {
        // Check if the assigned key is pressed
        if (Input.GetKeyDown(debugKeyCode))
        {
           
            AudioManager.Instance.PlaySFX("bike");
        }
    }
}
