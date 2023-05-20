using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(fileName = "Item", menuName = "Scriptable object/Items", order = int.MaxValue)]
public class Item : ScriptableObject
{
    public int itemId;
    public ItemType itemType;
    public bool stackable = false;
    public Sprite itemImage;
}

public enum ItemType
{
    Material,
    Complete
}