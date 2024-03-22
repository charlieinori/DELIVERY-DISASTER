using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BUTTONCLICK : MonoBehaviour
{
    public void Playsound()
    {
        AudioManager.Instance.PlaySFX("Click");
    }

    


}
