using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    PlayerInventory inv;

    [SerializeField] private GameObject[] slots;
    //[SerializeField] Transform cellParent;
    //[SerializeField] GameObject cellPrefab;

    private void Awake()
    {
        inv = new PlayerInventory();
    }

    private void Start()
    {
        FindObjectOfType<UI>().OnItemAdded += HandleItemAdded;
    }

    private void HandleItemAdded(ItemData obj)
    {
        bool placed = false;
        for (int i = 0; i < slots.Length; i++)
        {
            if (!placed && slots[i].transform.GetChild(0).GetComponent<Image>().color != Color.white) 
            {
                slots[i].transform.GetChild(0).GetComponent<Image>().sprite = obj.Image;
                slots[i].transform.GetChild(0).GetComponent<Image>().color = Color.white;
                placed = true;
                PlayerInventory.inventory[i] = obj;
            }
        }
    }

    // instantiates slots for inventory
    /*public GameObject[] CreateCells()
    {
        GameObject[] cells = new GameObject[inventory.Cap];
        for (int i = 0; i < inventory.Cap; i++)
        {
            // ask if there is a better way for the following line
            Vector3 spawnPos = new Vector3(50 + (i * 50), 500, 0);
            cells[i] = Instantiate(cellPrefab, spawnPos, Quaternion.identity, cellParent);
        }
        return cells;
    }*/
  /*  public void UpdateInv()
    {
        for (int i = 0; i < inventory.Cap; i++)
        {
            if (inventory.Inventory[i] != null)
            {
                // ask about how to reference the "image" child of each of the slots
            }
        }
    }*/
}
