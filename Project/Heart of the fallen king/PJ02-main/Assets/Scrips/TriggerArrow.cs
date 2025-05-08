using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArrow : MonoBehaviour
{
    public List<GameObject> Arrows = new List<GameObject>();
    private List<Rigidbody2D> rigidbodies = new List<Rigidbody2D>();
    public float resetHeight = -2f; 
    public float delayBetweenDrops = 0.1f;
    public List<Vector3> resetPositions = new List<Vector3>();

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject obj in Arrows)
        {
            Rigidbody2D rb = obj.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                rb.isKinematic = true; 
                rb.gravityScale = 0;   
                rigidbodies.Add(rb);
            }
            else
            {
                Debug.LogError(obj.name + " ไม่มี Rigidbody2D!");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
            Debug.Log("Player ชนแล้ว! วัตถุจะร่วงทีละชิ้น");
            StartCoroutine(DropItemsOneByOne()); 
        }
    }

    private IEnumerator DropItemsOneByOne()
    {
        foreach (Rigidbody2D rb in rigidbodies)
        {
            rb.isKinematic = false;
            rb.gravityScale = 3;

            yield return new WaitForSeconds(delayBetweenDrops); 
        }

        StartCoroutine(ResetItems()); 
    }

    private IEnumerator ResetItems()
    {
        yield return new WaitForSeconds(2f);

        for (int i = 0; i < rigidbodies.Count; i++)
        {
            Rigidbody2D rb = rigidbodies[i];
            if (rb.transform.position.y < resetHeight) 
            {
                rb.isKinematic = true;
                rb.gravityScale = 0;
                rb.transform.position = resetPositions[i];
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
