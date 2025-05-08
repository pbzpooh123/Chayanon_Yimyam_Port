using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Down : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Down")) 
        {
            Debug.Log("Player touched the item! Changing scene...");

            SceneManager.LoadScene(4);
        }
    }
}
