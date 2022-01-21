using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemOnWorld : MonoBehaviour
{
    public Item thisItem;
    public Inventory playerInventory;
    /*
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            AddNewItem();
            Destroy(gameObject);
        }
    }
    */

    public void AddNewItem()
    {
        //Debug.Log("canPick");
        playerInventory.itemList.Add(thisItem);
        InventoryManager.CreateNewItem(thisItem);
    }
}
