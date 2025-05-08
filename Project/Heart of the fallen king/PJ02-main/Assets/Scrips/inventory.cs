using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    public bool swordValue = true;
    public bool hasLighter = false;
    public int puzzle = 0;

    // Method to increase sword value
    public void IncreaseSwordValue()
    {
        swordValue = true;
        Debug.Log("Sword value increased. Current sword value: " + swordValue);
    }
    
    public void IncreaselighterValue()
    {
        hasLighter = true;
    }
    
    public void IncreasepuzzleValue()
    {
        puzzle += 1;
        
    }
}
