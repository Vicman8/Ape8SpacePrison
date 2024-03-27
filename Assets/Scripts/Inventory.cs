using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory 
{
    GameObject[] inventory;
    private int cap;

    void createInventory()
    {
        inventory = new GameObject[cap];
    }

}
