using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory
{
    public GameObject[] Inventory; 
    public int cap = 5;

    public PlayerInventory()
    {
        this.cap = 5;
        Inventory = new GameObject[this.cap];
    }

    // returns true if Inventory is full
    public bool isFull()
    {
        foreach (GameObject i in Inventory)
        {
            if (i == null)
            {
                return false;
            }
        }
        return true;
    }
   

    // adds item to Inventory if Inventory isn't full
    public void AddItem(GameObject item)
    {
        bool placed = false;

        if (!isFull())
        {
            for (int i = 0; i < Inventory.Length; i++)
            {
                if (Inventory[i] == null && !placed)
                {
                    placed = true;
                    Inventory[i] = item;
                }
            }
        }
    }

    // removes a given item from Inventory
    public void RemoveItem(GameObject item)
    {
        for (int i = 0; i < Inventory.Length; i++)
        {
            if (Inventory[i] == item)
            {
                Inventory[i] = null;
            }
        }
    }

    // increases Inventory capacity
    public void IncreaseCapacity(int capInc)
    {
        GameObject[] temp = new GameObject[cap + capInc];

        for (int i = 0; i < Inventory.Length; i++)
        {
            temp[i] = Inventory[i];
        }
        Inventory = temp;
    }

}
