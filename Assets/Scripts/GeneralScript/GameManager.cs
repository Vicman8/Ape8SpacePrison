using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    PlayerInventory inventory;

    private GameObject[] slots;

    [SerializeField] Transform cellParent;
    [SerializeField] GameObject cellPrefab;

    private void Awake()
    {
        inventory = new PlayerInventory();
        slots = CreateCells();
    }

    // instantiates slots for inventory
    public GameObject[] CreateCells()
    {
        GameObject[] cells = new GameObject[inventory.Cap];
        for (int i = 0; i < inventory.Cap; i++)
        {
            // ask if there is a better way for the following line
            Vector3 spawnPos = new Vector3(50 + (i * 50), 500, 0);
            cells[i] = Instantiate(cellPrefab, spawnPos, Quaternion.identity, cellParent);
        }
        return cells;
    }
    public void UpdateInv()
    {
        for (int i = 0; i < inventory.Cap; i++)
        {
            if (inventory.Inventory[i] != null)
            {
                // ask about how to reference the "image" child of each of the slots
            }
        }
    }
}
