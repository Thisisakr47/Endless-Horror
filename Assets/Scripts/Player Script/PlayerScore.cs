using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public Transform player;
    public Text ScoreText;
    private float izpos;
    private bool begin = false;
    public float distance = 0f;

    void start()
    {
        izpos = player.position.z;
    }

    void Update()
    {
        if(Input.GetKey("backspace"))
        {
            begin = true;
        }
        if(begin == true)
        {
            distance = player.position.z - izpos;
        }
        else
        {
            distance = 0;
        }
        distance /= 10;
        ScoreText.text = distance.ToString("0");
    }
}
