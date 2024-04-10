using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory
{
    private GameObject[] inventory; 
    private int cap = 5;

    public PlayerInventory()
    {
        this.cap = 5;
        inventory = new GameObject[this.cap];
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
    public GameObject[] Inventory
    {
        get
        {
            return this.inventory;
        }
    }

    // returns true if Inventory is full
    public bool isFull()
    {
        foreach (GameObject i in inventory)
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
        //            inventory[i] = item;
        //        }
        //    }
        //}
    }

    // removes a given item from Inventory
    public void RemoveItem(GameObject item)
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
        GameObject[] temp = new GameObject[cap + capInc];

        for (int i = 0; i < inventory.Length; i++)
        {
            temp[i] = inventory[i];
        }
        inventory = temp;
    }

}
