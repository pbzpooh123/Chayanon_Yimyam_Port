using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountItem : MonoBehaviour
{
    public int itemCount = 0; 
    public Text itemText; 

    public void CollectItem()
    {
        itemCount++;
        UpdateItemUI(); 
    }

    void UpdateItemUI()
    {
        itemText.text = "" + itemCount; 
    }

    void isTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("item"))
        {
            Debug.Log("Player touched the item!");
            CollectItem(); 
            Destroy(other.gameObject); 
        }
    }


}
