using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    // List to track the IDs of the collected puzzle pieces
    public List<int> collectedPieces = new List<int>();
    public DraggablePiece[] puzzlePieces;
    public GameObject chest;
    private inventory playerInventory; // Ensure this is correctly named as per your Inventory class

    // Array of GameObjects representing puzzle piece slots in the UI
    public GameObject[] puzzlePieceSlots;

    void Start()
    {
        // Assign PuzzleManager reference to each puzzle piece
        foreach (DraggablePiece piece in puzzlePieces)
        {
            piece.puzzleManager = this; // Assign the current instance of PuzzleManager
        }

        // Initialize playerInventory - find the Inventory component in your player GameObject
        playerInventory = FindObjectOfType<inventory>(); // Make sure the Inventory script is attached to a GameObject in the scene
        if (playerInventory == null)
        {
            Debug.LogError("Player Inventory not found! Please ensure it is attached to a GameObject.");
        }
    }

    // Method to collect a puzzle piece
    public void CollectPiece(int pieceID)
    {
        if (!collectedPieces.Contains(pieceID))
        {
            collectedPieces.Add(pieceID); // Add the piece ID to the list
            Debug.Log("Collected puzzle piece: " + pieceID);
        }
    }

    // Method to display collected puzzle pieces in the UI
    public void DisplayCollectedPieces()
    {
        for (int i = 0; i < puzzlePieceSlots.Length; i++)
        {
            if (collectedPieces.Contains(i))
            {
                puzzlePieceSlots[i].SetActive(true); // Show the puzzle piece slot if collected
                puzzlePieceSlots[i].GetComponent<DraggablePiece>().enabled = true; // Enable dragging only for collected pieces
            }
            else
            {
                puzzlePieceSlots[i].SetActive(false); // Hide pieces that haven't been collected
            }
        }
    }

    public void CheckPuzzleCompletion()
    {
        bool allPlacedCorrectly = true;

        // Iterate through all puzzle pieces to see if they're correctly placed
        foreach (DraggablePiece piece in puzzlePieces)
        {
            if (!piece.isCorrectlyPlaced) // Check if the piece is correctly placed
            {
                allPlacedCorrectly = false;
                Debug.Log("Puzzle not completed, piece " + piece.gameObject.name + " is not correctly placed.");
                break; // Exit early if any piece is not placed correctly
            }
        }

        // If all pieces are placed correctly, show the chest
        if (allPlacedCorrectly)
        {
            OnPuzzleCompleted(); // Puzzle is fully completed!
        }
    }

    private void OnPuzzleCompleted()
    {
        playerInventory.IncreasepuzzleValue(); // Ensure this function is implemented in your Inventory class
        Debug.Log("Puzzle Completed! Chest is now visible.");
    }

    public void Update()
    {
        if (playerInventory != null && playerInventory.puzzle == 6) // Ensure playerInventory is not null
        {
            chest.SetActive(true);
        }
    }
}

