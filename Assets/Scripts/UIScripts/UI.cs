using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    int capacity = PlayerInventory.Inv.cap;
    GameObject[] inventory = PlayerInventory.Inv.Inventory;
    [SerializeField] GameObject[] cells;
    private void Update()
    {
        
    }
    private void Start()
    {
        GameObject[] inventory = new GameObject[capacity];
        
    }
}
