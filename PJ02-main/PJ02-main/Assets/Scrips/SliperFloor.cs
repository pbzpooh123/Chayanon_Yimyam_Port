using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliperFloor : MonoBehaviour
{
    public Vector2 pushDirection = new Vector2(-1, 0);
    public float pushForce = 10f; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        {
            Rigidbody2D playerRb = collision.GetComponent<Rigidbody2D>(); 
            if (playerRb != null)
            {
                playerRb.AddForce(pushDirection.normalized * pushForce, ForceMode2D.Force);
            }
        }
    }
}
