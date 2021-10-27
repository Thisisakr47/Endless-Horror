using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InstructionsMenu : MonoBehaviour
{
    public GameObject InstructionPanel;

    void Update()
    {
        if(Input.GetKey("backspace"))
        {
            InstructionPanel.SetActive(false);
        }
    }
}
