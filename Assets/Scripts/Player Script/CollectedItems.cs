using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectedItems : MonoBehaviour
{
    public Text ItemsCount;
    public int count = 0;

    void Update()
    {
        ItemsCount.text = count.ToString();
    }
}
