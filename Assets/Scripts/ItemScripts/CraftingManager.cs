using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Storereference to list of crafting data, handle queries intocrafting
/// </summary>
public class CraftingManager : MonoBehaviour
{
    [SerializeField] private List<CraftData> craftableItems = new List<CraftData>();
    [SerializeField] private List<Item> itemPrefabs = new List<Item>();

    private static CraftingManager instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        //TryCraftMaterials(ItemData.ItemTypeEnum.TP, ItemData.ItemTypeEnum.Soap);
        //TryCraftMaterials(ItemData.ItemTypeEnum.Eyeball, ItemData.ItemTypeEnum.Soap);
        //TryCraftMaterials(ItemData.ItemTypeEnum.Soap, ItemData.ItemTypeEnum.Eyeball);
    }

    public static CraftData TryCraftMaterials(ItemData.ItemTypeEnum ingredient1, ItemData.ItemTypeEnum ingredient2)
    {
        foreach(CraftData craft in instance.craftableItems) // Look through all craftable items
        {
            bool success = true;
            foreach(ItemData.ItemTypeEnum item in craft.Ingredients) 
            {
                if(item != ingredient1 && item != ingredient2) // check if ing1/2 is not in this items ingredients
                {
                    success = false;
                    break;
                }
            }
            if (success)
            {
                Debug.Log($"{ingredient1} + {ingredient2} = {craft.Result}");
                return craft;
            }
        }
        Debug.Log($"{ingredient1} + {ingredient2} = No Result!");
        return null;
    }

   
}
