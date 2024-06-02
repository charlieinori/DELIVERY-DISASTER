using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BUTTONCLICK : MonoBehaviour
{
    public void Playsound()
    {
        AudioManager.Instance.PlaySFX("Click");
    }

    public void Playgame()
    {
        SceneManager.LoadSceneAsync("zzz");


    }

    public void Playgame1()
    {
        SceneManager.LoadSceneAsync("SCENE 1");


    }

    public void Playgame2()
    {
        SceneManager.LoadSceneAsync("SCENE 2");


    }

    public void Playgame3()
    {
        SceneManager.LoadSceneAsync("SCENE 3");


    }

    public void MENU()
    {
        SceneManager.LoadSceneAsync("MENU");


    }


}
