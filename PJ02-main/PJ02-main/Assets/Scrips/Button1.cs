using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1 : MonoBehaviour
{
    public int buttonID; // 1 for Button1, 2 for Button2, 3 for Button3
    private gatepuzzle gatePuzzle;
    private bool playerInRange = false; // Track if the player is in range

    void Start()
    {
        // Find the GatePuzzle script in the scene
        gatePuzzle = FindObjectOfType<gatepuzzle>();
    }

    // When the player enters the button trigger zone
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Ensure only the player triggers the button
        {
            playerInRange = true;
           
        }
    }

    // When the player exits the button trigger zone
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            
        }
    }

    void Update()
    {
        // Check if player is in range and presses E
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            PressButton();
        }
    }

    // Based on buttonID, trigger the appropriate button function in GatePuzzle
    private void PressButton()
    {
        switch (buttonID)
        {
            case 1:
                gatePuzzle.Button1Press();
                break;
            case 2:
                gatePuzzle.Button2Press();
                break;
            case 3:
                gatePuzzle.Button3Press();
                break;
            default:
                Debug.LogWarning("Invalid buttonID");
                break;
        }

        Debug.Log("Button " + buttonID + " pressed.");
    }
}
