using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PumpkinCollector : MonoBehaviour
{
    private float yrotate = 2.5f;
    public AudioSource SoundFX;

    void OnTriggerEnter(Collider info)
    {
        this.gameObject.SetActive(false);
        FindObjectOfType<CollectedItems>().count += 1;
        SoundFX.Play();
    }

    void Update()
    {
        transform.Rotate(0,yrotate,0,Space.World);
    }
}
