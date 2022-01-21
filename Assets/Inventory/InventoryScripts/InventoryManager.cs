using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    static InventoryManager instance;

    public Inventory myBag;
    public GameObject slotGrid;
    public Slot slotPrefab;
    public Text itemInformation;

    void Awake()
    {
        if (instance != null)
            Destroy(this);
        instance = this;
    }

    public static void CreateNewItem(Item item)
    {
        //Debug.Log("canAdd");
        Slot newItem = Instantiate(instance.slotPrefab,instance.slotGrid.transform.position,Quaternion.identity);
        newItem.gameObject.transform.SetParent(instance.slotGrid.transform);
        newItem.slotItem = item;
        newItem.slotImage.sprite = item.itemImage;
    }

    public static void deleteItem(string itemName)
    {
        for(int i = 0; i<instance.slotGrid.transform.childCount; i++)
        {
            Debug.Log(itemName);
            Debug.Log(instance.slotGrid.name);
            if (instance.slotGrid.name == itemName)
            {
                Destroy(instance.slotGrid.transform.GetChild(i).gameObject);
                //instance.slots.Clear();
            }
            
        }
        
    }

}
