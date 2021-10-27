using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator ani;
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKey("backspace"))
        {
            ani.SetBool("Running", true);
        }

        // if(Input.GetKey("space"))
        // {
        //     ani.SetTrigger("Jump");
        // }
    }
}
