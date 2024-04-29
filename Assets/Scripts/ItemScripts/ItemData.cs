using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemData
{
    public string Name { get { return name; } }
    public Sprite Image { get { return image; } }

    public ItemTypeEnum ItemType { get { return itemType; } }

    public List<ItemTypeEnum> CraftingMaterials { get { return CraftingMaterials;  } }

    public enum ItemTypeEnum { Eyeball, Soap, TP, Slimecup, Tentacle, Slimeplunger, Cigs}

    [SerializeField] private string name;
    [SerializeField] private Sprite image;
    [SerializeField] private ItemTypeEnum itemType;
}
