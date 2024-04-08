using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerInventory inventory;

    [SerializeField] Transform cellParent;
    [SerializeField] GameObject cellPrefab;

    private void Awake()
    {
        PlayerInventory inventory = new PlayerInventory();
        //GameObject[] slots = CreateCells();
    }

    /*public GameObject[] CreateCells()
    {
        GameObject[] cells = new GameObject[inventory.cap];
        for (int i = 0; i < inventory.cap; i++)
        {
            Vector3 spawnPos = new Vector3(-300 + (i * 50), 150, 0);
            cells[i] = Instantiate(cellPrefab, spawnPos, Quaternion.identity);
            //cells[i].transform.SetParent(cellParent);
        }
        return cells;
    }*/
}
