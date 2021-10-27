using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float forwardspeed = 20f;
    public float sidespeed = 20f;
    private bool lose = false;
    private int ipos = 200;
    private bool begin = false;
    public Transform trns;
    public AudioSource BeforeStartFX;
    public AudioSource PlaySoundFX;

    void OnTriggerEnter(Collider info)
    {
        if(info.CompareTag("Obstacle"))
        {
            FindObjectOfType<PlayerLife>().count -= 1;
            if(FindObjectOfType<PlayerLife>().count == 0)
            {
                FindObjectOfType<PlayerAnimation>().ani.SetBool("Running", false);
                lose = true;
                trns.Rotate(-trns.rotation.x,-trns.rotation.y,-trns.rotation.z,Space.Self);
                transform.position = new Vector3(trns.position.x, trns.position.y, trns.position.z - 1f);
                PlaySoundFX.Stop();
                FindObjectOfType<GameOver>().gover();
            }
        }
    }


    void Update()
    {
        if(Input.GetKey("backspace"))
        {
            if(begin == false)
            {
                begin = true;
                BeforeStartFX.Stop();
                PlaySoundFX.Play();
            }
        }
        if(trns.position.z > ipos && forwardspeed <= 100f){
            forwardspeed += 2f;
            sidespeed += 0.15f;
            ipos += 100;
        }
        trns.Rotate(-trns.rotation.x,-trns.rotation.y,-trns.rotation.z,Space.Self);
        if(lose == false && begin == true)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * forwardspeed, Space.World);
        }
        if(Input.GetKey("a") && lose == false && begin == true)
        {
            if(this.gameObject.transform.position.x > Boundary.leftboundary)
            {
                transform.Translate(Vector3.left * Time.deltaTime * sidespeed, Space.World);
            }
        }
        if(Input.GetKey("d") && lose == false && begin == true)
        {
            if(this.gameObject.transform.position.x < Boundary.rightboundary)
            {
                transform.Translate(Vector3.right * Time.deltaTime * sidespeed, Space.World);
            }
        }
    }
}
