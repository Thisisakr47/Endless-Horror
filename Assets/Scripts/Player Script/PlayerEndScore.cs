using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerEndScore : MonoBehaviour
{
    public Text ScoreText;
    void Update()
    {
        ScoreText.text = FindObjectOfType<PlayerScore>().distance.ToString("0");
    }
}
