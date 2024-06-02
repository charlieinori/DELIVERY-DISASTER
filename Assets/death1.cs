using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death1 : MonoBehaviour
{


    void OnTriggerEnter(Collider FallingPoint)
    {
        SceneManager.LoadScene("WEWONNO2");
    }

}
