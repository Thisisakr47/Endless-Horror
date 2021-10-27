using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public float GameOverDelay = 3f;
    public GameObject PlayerGameOverUI;
    public AudioSource GameOverFX;

    public void gover(){
        GameOverFX.Play();
        PlayerGameOverUI.SetActive(true);
        Invoke("Over",GameOverDelay);
    }

    void Over(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
