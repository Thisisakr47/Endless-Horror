using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeCollector : MonoBehaviour
{
    private float yrotate = 2.5f;
    public AudioSource PowerUp;

    void OnTriggerEnter(Collider info)
    {
        PowerUp.Play();
        this.gameObject.SetActive(false);
        FindObjectOfType<PlayerLife>().count += 1;
    }

    void Update()
    {
        transform.Rotate(0,yrotate,0,Space.World);
    }
    
}
