using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openmenu : MonoBehaviour
{
    public Canvas endMenu;
    public Canvas Button;
    

    public void OpenM()
    {
        endMenu.enabled = true;
        Button.enabled = false;
        Time.timeScale = 0f;


    }

    public void closeM()
    {

        endMenu.enabled = false;
        Button.enabled = true;
        Time.timeScale = 1f;

    }
}
