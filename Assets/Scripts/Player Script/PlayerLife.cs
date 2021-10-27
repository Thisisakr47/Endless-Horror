using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    public Text LifeText;
    public int count = 1;

    void Update()
    {
        LifeText.text = count.ToString();
    }
}
