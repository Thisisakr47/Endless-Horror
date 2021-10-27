using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeGenerator : MonoBehaviour
{
    public GameObject Life;
    private float pos = 1500f;
    private bool generate = false;
    private float inc = 250f;
    private float cnt = 4;
    void Update()
    {
        if(generate == false)
        {
            generate = true;
            cnt+=2;
            StartCoroutine(generator());
        }
    }

    IEnumerator generator()
    {
        Instantiate(Life, new Vector3(1.1f,0.3f,pos), Quaternion.identity);
        Debug.Log(pos);
        pos += inc*cnt;
        yield return new WaitForSeconds(30);
        generate = false;
    }
}
