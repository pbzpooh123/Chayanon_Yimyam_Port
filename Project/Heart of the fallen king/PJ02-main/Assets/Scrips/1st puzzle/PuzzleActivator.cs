using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleActivator : MonoBehaviour
{
    public PuzzleManager puzzleManager;
    public GameObject puzzleUI; // Reference to the puzzle UI mini-game

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Ensure player has a Player tag
        {
            Debug.Log("Player entered the puzzle area. Press 'E' to start puzzle.");
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E)) // Press 'E' to activate puzzle
        {
            Debug.Log("Player press");
            ActivatePuzzle();
        }
    }

    void ActivatePuzzle()
    {
        puzzleUI.SetActive(true); // Show the puzzle mini-game
        Time.timeScale = 0f; // Pause the game when the puzzle is active
        puzzleManager.DisplayCollectedPieces(); // Show collected pieces
    }

    public void ClosePuzzle()
    {
        puzzleUI.SetActive(false); // Hide the puzzle UI when done
        Time.timeScale = 1f; // Resume the game
    }
}