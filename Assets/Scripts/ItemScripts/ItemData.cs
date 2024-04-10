using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemData
{
    public string Name { get { return name; } }
    public Sprite Image { get { return image; } }

    [SerializeField] private string name;
    [SerializeField] private Sprite image;
}
