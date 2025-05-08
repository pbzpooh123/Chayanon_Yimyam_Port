using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knight : MonoBehaviour
{

    private bool playerInRange = false; // Is the player near the torch?
    public GameObject sword;
    public GameObject metaldoor;
    private inventory playerInventory;
    

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
        if (playerInRange && Input.GetKeyDown(KeyCode.E) && playerInventory != null && playerInventory.swordValue)
        {
            LightTorch();
        }
    }

    private void LightTorch()
    {
        sword.SetActive(true);
        Vector3 startPosition = sword.transform.position;
        metaldoor.SetActive(false);
    }
}


