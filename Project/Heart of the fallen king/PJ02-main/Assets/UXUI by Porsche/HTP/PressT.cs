using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressT : MonoBehaviour
{
    public static bool Tutorials = false;

    public GameObject TutorialUI;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (Tutorials)
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
        TutorialUI.SetActive(false);
        Tutorials = false;
    }

    void Pause()
    {
        TutorialUI.SetActive(true);
        Tutorials = true;
    }
}
