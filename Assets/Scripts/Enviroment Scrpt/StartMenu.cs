using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public AudioSource StartMenuFX;

    public void gamestart()
    {
        StartMenuFX.Stop();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void gamequit()
    {
        StartMenuFX.Stop();
        Application.Quit();
    }
}
