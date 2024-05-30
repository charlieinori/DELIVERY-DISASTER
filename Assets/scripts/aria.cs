using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aria : MonoBehaviour
{

    void start()
    {
        AudioManager.Instance.PlaySFX("bike1");
        
    }
    void Update()
    {
        // Check if the "W" key was pressed down this frame
        if (Input.GetKeyDown(KeyCode.W))
        {
            AudioManager.Instance.ToggleSFX();
        }

        // Check if the "W" key was released this frame
        if (Input.GetKeyUp(KeyCode.W))
        {
            AudioManager.Instance.ToggleSFX();
        }
    }

}
