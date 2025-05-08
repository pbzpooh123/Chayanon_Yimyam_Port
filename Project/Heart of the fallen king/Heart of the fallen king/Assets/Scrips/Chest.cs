using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public GameObject sword; // Reference to the sword object
    public Transform swordFloatPosition; // Where the sword will float to
    public float floatDuration = 1f; // Duration of the sword floating animation
    public int swordValueIncrease = 1; // Value increase for the sword
    private bool playerInRange = false; // To check if the player is near
    private bool chestOpened = false; // To prevent multiple openings
    private inventory playerInventory; // Reference to the player's inventory
    
    void Update()
    {
        // Check for input and if the player is near the chest
        if (playerInRange && Input.GetKeyDown(KeyCode.E) && !chestOpened)
        {
            StartCoroutine(OpenChest());
        }
    }

    private IEnumerator OpenChest()
    {
        chestOpened = true;
        
        // Show sword and animate it upwards
        sword.SetActive(true);
        Vector3 startPosition = sword.transform.position;
        Vector3 endPosition = swordFloatPosition.position;
        float elapsedTime = 0;

        while (elapsedTime < floatDuration)
        {
            elapsedTime += Time.deltaTime;
            sword.transform.position = Vector3.Lerp(startPosition, endPosition, elapsedTime / floatDuration);
            yield return null;
        }

        // Keep the sword displayed for a second
        yield return new WaitForSeconds(1f);

        // Hide sword and update player inventory
        sword.SetActive(false);
        playerInventory.IncreaseSwordValue();
    }

    // Check if the player enters the trigger area
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            playerInventory = other.GetComponent<inventory>(); // Get the player's inventory
        }
    }

    // Check if the player exits the trigger area
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }
}

