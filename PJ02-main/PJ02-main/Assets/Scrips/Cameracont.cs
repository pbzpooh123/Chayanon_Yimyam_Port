using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracont : MonoBehaviour
{
    public GameObject player;       // Reference to the player object
    public float offset;            // Horizontal offset
    public float offsetSmoothing;   // Speed at which the camera follows the player
    private Vector3 playerPosition; // Store the player's position

    // Update is called once per frame
    void Update()
    {
        // Follow both horizontal (x) and vertical (y) positions of the player
        playerPosition = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);

        // Add horizontal offset depending on the player's facing direction
        if (player.transform.localScale.x > 0f)
        {
            playerPosition.x += offset;
        }
        else
        {
            playerPosition.x -= offset;
        }

        // Smoothly move the camera towards the player's position with the offset
        transform.position = Vector3.Lerp(transform.position, playerPosition, offsetSmoothing * Time.deltaTime);
    }
}
