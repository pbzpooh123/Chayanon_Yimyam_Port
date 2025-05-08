using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlePiece : MonoBehaviour
{
    public int pieceID; // Unique ID for each piece
    private PuzzleManager puzzleManager; // Reference to the puzzle manager

    void Start()
    {
        puzzleManager = FindObjectOfType<PuzzleManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CollectPiece();
        }
    }
    

    void CollectPiece()
    {
        puzzleManager.CollectPiece(pieceID); // Add the piece to the collected list
        Destroy(gameObject); // Remove the piece from the world
    }
}
