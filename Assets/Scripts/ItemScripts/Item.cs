using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private ItemData data;


    private void OnTriggerEnter2D(Collider2D collision)
    {        
        if (!PlayerInventory.isFull())
        {
            FindObjectOfType<UI>().AddItem(data);
            Destroy(gameObject);
        }
    }
}
