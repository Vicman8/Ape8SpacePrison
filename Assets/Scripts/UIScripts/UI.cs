using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public Action<ItemData> OnItemAdded;

    public void AddItem(ItemData item)
    {
        OnItemAdded?.Invoke(item);
    }
}
