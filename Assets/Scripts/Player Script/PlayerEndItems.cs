using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerEndItems : MonoBehaviour
{
    public Text ScoreText;
    void Update()
    {
        ScoreText.text = FindObjectOfType<CollectedItems>().count.ToString();
    }
}
