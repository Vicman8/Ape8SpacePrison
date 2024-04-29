using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory
{
    private static PlayerInventory instance;
    public static PlayerInventory Instance { get { return instance; } }

    public static ItemData[] inventory; 
    private int cap = 5;

    public PlayerInventory()
    {
        this.cap = 5;
        inventory = new ItemData[this.cap];
    }

    public static void Initialize()
    {
        if(instance == null)
        {
            instance = new PlayerInventory();
        }
    }



    // ask about the two following methods
    public int Cap
    {
        get
        {
            return this.cap;
        }
        set
        {
            cap = value;
        }
    }
    /*public ItemData[] Inventory
    {
        //public double this[int i]
    
        get { return inventory; }
    }*/


    // returns true if Inventory is full
    public static bool isFull()
    {
        foreach (ItemData i in inventory)
        {
            if (i == null)
            {
                return false;
            }
        }
        return true;
    }
   

    // adds item to Inventory if Inventory isn't full
    public void AddItem(ItemData item)
    {
        Debug.Log("Added " + item.Name + " to inventory");
        return;

        //bool placed = false;

        //if (!isFull())
        //{
        //    for (int i = 0; i < inventory.Length; i++)
        //    {
        //        if (inventory[i] == null && !placed)
        //        {
        //            placed = true;
        //        }
        //    }
        //}
    }

    // removes a given item from Inventory
    public static void RemoveItem(ItemData item)
    {
        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i] == item)
            {
                inventory[i] = null;
            }
        }
    }

    // increases Inventory capacity
    public void IncreaseCapacity(int capInc)
    {
        ItemData[] temp = new ItemData[cap + capInc];

        for (int i = 0; i < inventory.Length; i++)
        {
            temp[i] = inventory[i];
        }
        inventory = temp;
    }

    //Check if the player has a specific item in their inventory
    public bool HasItem(ItemData.ItemTypeEnum itemType)
    {
        foreach (ItemData inventoryItem in inventory)
        {
            if (inventoryItem.ItemType == itemType)
            {
                return true;
            }
        }
        return false;
    }

    public bool CraftItem(ItemData item)
    { 
        return true; 
    //{
    //    foreach (ItemData material in item.CraftingMaterials)
    //    {
    //        if (!HasItem(material))
    //        {
    //            Debug.Log("Missing required materials for crafting " + item.Name);
    //            return false;
    //        }
    //    }
    //    //Deduct crafting materials from inventory
    //    foreach (ItemData material in item.CraftingMaterials)
    //    {
    //        RemoveItem(material);
    //    }

    //    //Add crafted item to inventory
    //    AddItem(item);
    //    Debug.Log("Crafted " + item.Name);
    //    return true;
        
    }

}
