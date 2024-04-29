using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Craft Data", menuName = "Ape8/Crafting")]
public class CraftData : ScriptableObject
{
    public ItemData.ItemTypeEnum Result { get { return result; } }
    public ItemData ItemData { get { return itemPrefab.GetComponent<Item>().ItemData; } }
    public List<ItemData.ItemTypeEnum> Ingredients { get { return ingredients; } }

    [SerializeField] private ItemData.ItemTypeEnum result;
    [SerializeField] private GameObject itemPrefab;
    [SerializeField] private List<ItemData.ItemTypeEnum> ingredients = new List<ItemData.ItemTypeEnum>();
}