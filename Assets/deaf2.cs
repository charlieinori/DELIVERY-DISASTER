using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deaf2 : MonoBehaviour
{


    void OnTriggerEnter(Collider FallingPoint)
    {
        SceneManager.LoadScene("WELOSTNO3");
    }

}