using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public ItemData ItemData { get { return data; } }

    [SerializeField] private ItemData data;


    private void OnTriggerEnter2D(Collider2D collision)
    {        
        if (!PlayerInventory.isFull())
        {
            FindObjectOfType<UI>().AddItem(data);
            Destroy(gameObject);
        }
    }

    //Craft Item when player interacts with it
    private void Interact()
    {
        if (!PlayerInventory.isFull())
        {
            //PlayerInventory inventory = FindObjectOfType<PlayerInventory>();
            //if (inventory.CraftItem(data))
           // {
           //     Destroy(gameObject);
           // }
        }
    }
}
