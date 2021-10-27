using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] level;
    private float zIndex = 205.611f;
    private bool generate = false;
    private int levelnum;
    private float cnt = 3f;
    private float cnt2 = 0f;
    private float pos;
    private List<GameObject> ActiveLevels;

    void Start()
    {
        ActiveLevels = new List<GameObject>(); 
    }

    void Update()
    {
        pos = FindObjectOfType<PlayerMovement>().trns.position.z - 91f;
        if(generate == false && (pos/195) >= cnt2)
        {
            cnt2++;
            generate = true;
            StartCoroutine(generator());
        }
        
        if( (pos/210) >= cnt)
        {
            cnt++;
            DeleteLevel();
        }
    }

    IEnumerator generator()
    {
        levelnum = Random.Range(0,3);
        var thislevel = Instantiate(level[levelnum], new Vector3(18.10771f,-8.494808f,zIndex), Quaternion.identity);
        zIndex += 205.611f;
        ActiveLevels.Add(thislevel);
        yield return new WaitForSeconds(0);
        generate = false;
    }

    void DeleteLevel()
    {
        Destroy(ActiveLevels[0]);
        ActiveLevels.RemoveAt (0);
    }
}
