using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressY : MonoBehaviour
{
    public static bool Tutorials2 = false;

    public GameObject Tutorial2UI;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            if (Tutorials2)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        Tutorial2UI.SetActive(false);
        Tutorials2 = false;
    }

    void Pause()
    {
        Tutorial2UI.SetActive(true);
        Tutorials2 = true;
    }
}
