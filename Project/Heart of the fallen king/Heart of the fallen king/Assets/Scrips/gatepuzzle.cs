using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gatepuzzle : MonoBehaviour
{// References to the four gate bars
    public GameObject Bar1;
    public GameObject Bar2;
    public GameObject Bar3;
    public GameObject Bar4;
    public GameObject crown;

    // The current state of each bar (true = open, false = closed)
    private bool bar1Open = false;
    private bool bar2Open = false;
    private bool bar3Open = false;
    private bool bar4Open = false;

    // Keep track of the correct button sequence
    private int currentStep = 0;
    private readonly int[] correctSequence = { 3, 1, 2 };

    void Start()
    {
        // Ensure all bars are closed at the start
        ResetBars();
    }

    // Function for Button 1 (affects Bar1 and Bar3)
    public void Button1Press()
    {
        if (currentStep == 1) // Only allow if the correct order is being followed
        {
            ToggleBar(ref bar1Open, Bar1);
            ToggleBar(ref bar3Open, Bar3);
            currentStep++;
            Debug.Log("Button 1 pressed");
        }
        else
        {
            Debug.Log("Wrong order! Resetting puzzle.");
            ResetPuzzle();
        }
    }

    // Function for Button 2 (affects Bar3 and Bar4)
    public void Button2Press()
    {
        if (currentStep == 2) // Only allow if the correct order is being followed
        {
            ToggleBar(ref bar3Open, Bar3);
            ToggleBar(ref bar4Open, Bar4);
            currentStep++;
            Debug.Log("Button 2 pressed");
            CheckIfPuzzleSolved();
        }
        else
        {
            Debug.Log("Wrong order! Resetting puzzle.");
            ResetPuzzle();
        }
    }

    // Function for Button 3 (affects Bar2 and Bar3)
    public void Button3Press()
    {
        if (currentStep == 0) // Only allow if the correct order is being followed
        {
            ToggleBar(ref bar2Open, Bar2);
            ToggleBar(ref bar3Open, Bar3);
            currentStep++;
            Debug.Log("Button 3 pressed");
        }
        else
        {
            Debug.Log("Wrong order! Resetting puzzle.");
            ResetPuzzle();
        }
    }

    // Toggle the state of a bar (open/close)
    private void ToggleBar(ref bool barState, GameObject bar)
    {
        barState = !barState;
        bar.SetActive(!barState); // If barState is true (open), we hide the bar (set it inactive)
    }

    // Check if all bars are open (puzzle solved)
    private void CheckIfPuzzleSolved()
    {
        if (bar1Open && bar2Open && bar3Open && bar4Open)
        {
            Debug.Log("Puzzle solved! Gate opened.");
            crown.SetActive(true);
            // You can add any additional logic here to indicate the gate is open
        }
        else
        {
            Debug.Log("Puzzle failed. Try again.");
            ResetPuzzle();
        }
    }

    // Reset the puzzle: close all bars and reset the sequence
    private void ResetPuzzle()
    {
        Debug.Log("Resetting puzzle...");
        currentStep = 0;
        ResetBars();
    }

    // Close all bars
    private void ResetBars()
    {
        bar1Open = false;
        bar2Open = false;
        bar3Open = false;
        bar4Open = false;

        Bar1.SetActive(true);
        Bar2.SetActive(true);
        Bar3.SetActive(true);
        Bar4.SetActive(true);
    }
}
