using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveTorch : MonoBehaviour
{
    private bool playerInRange = false; // Is the player near the torch?
    private bool isLit = false; // Is the torch already lit?
    public GameObject torchLightEffect; // Reference to the torch light effect (e.g., flame)
    public TorchManager torchManager; // Reference to the TorchManager

    private inventory playerInventory;

    void Start()
    {
        torchLightEffect.SetActive(false); // Ensure the torch is not lit at the start
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            playerInventory = other.GetComponent<inventory>();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E) && playerInventory != null && playerInventory.hasLighter)
        {
            LightTorch();
        }
    }

    private void LightTorch()
    {
        if (!isLit)
        {
            isLit = true;
            torchLightEffect.SetActive(true); // Light the torc
                // Notify the torch manager
            if (torchManager != null)
            {
                torchManager.TorchLit();
            }

            Debug.Log("Torch lit!");
        }
        else
        {
            Debug.Log("Torch is already lit.");
        }
    }
}
