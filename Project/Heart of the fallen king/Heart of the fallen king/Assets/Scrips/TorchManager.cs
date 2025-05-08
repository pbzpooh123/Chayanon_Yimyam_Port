using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchManager : MonoBehaviour
{
    public int torchesLit = 0; // Number of torches lit
    public int totalTorches = 2; // Total number of torches to light before revealing chest
    public GameObject secretChest; // Reference to the secret chest GameObject

    void Start()
    {
        secretChest.SetActive(false); // Hide the chest at the start
    }

    // This method is called by each torch when it gets lit
    public void TorchLit()
    {
        torchesLit++;

        // Check if the required number of torches have been lit
        if (torchesLit >= totalTorches)
        {
            RevealSecretChest();
        }
    }

    // Reveal the secret chest
    private void RevealSecretChest()
    {
        secretChest.SetActive(true); // Activate the chest GameObject
        Debug.Log("Secret chest revealed!");
    }
}
