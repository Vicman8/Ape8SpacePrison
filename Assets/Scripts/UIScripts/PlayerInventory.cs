using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory
{
    public static ItemData[] inventory; 
    private int cap = 5;

    public PlayerInventory()
    {
        this.cap = 5;
        inventory = new ItemData[this.cap];
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
    public void RemoveItem(ItemData item)
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

}
