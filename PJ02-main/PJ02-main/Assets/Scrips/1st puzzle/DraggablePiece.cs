using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DraggablePiece : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Vector3 startPosition;
    private Transform puzzleParent;
    public Transform correctPosition;
    public float snapDistance = 50f;

    private CanvasGroup canvasGroup;
    public bool isCorrectlyPlaced = false; // Tracks if the piece is correctly placed

    public PuzzleManager puzzleManager; // Reference to PuzzleManager

    void Start()
    {
        startPosition = transform.position;
        puzzleParent = transform.parent;
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (isCorrectlyPlaced) return; // If already placed, don't allow dragging
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (isCorrectlyPlaced) return; // If already placed, don't allow dragging
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (isCorrectlyPlaced) return; // If already placed, don't allow dragging
        canvasGroup.blocksRaycasts = true;

        // Check if the piece is close enough to snap to its correct position
        if (Vector3.Distance(transform.position, correctPosition.position) <= snapDistance)
        {
            SnapToCorrectPosition();
        }
        else
        {
            ResetPosition(); // Return to original position if it's not close enough
        }
    }

    private void SnapToCorrectPosition()
    {
        transform.position = correctPosition.position;
        isCorrectlyPlaced = true; // Mark the piece as correctly placed
        puzzleManager.CheckPuzzleCompletion(); // Notify PuzzleManager to check completion
    }

    private void ResetPosition()
    {
        transform.position = startPosition;
    }
}