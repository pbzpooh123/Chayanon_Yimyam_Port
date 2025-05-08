using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    public Rigidbody2D rb; 
    public Vector2 force = new Vector2(10f, 0f); 
    public float forceInterval = 2f;

    void Start()
    {
        InvokeRepeating("AddPendulumForce", 0f, forceInterval);
    }

    void AddPendulumForce()
    {
        rb.AddForce(force); 
    }
}
