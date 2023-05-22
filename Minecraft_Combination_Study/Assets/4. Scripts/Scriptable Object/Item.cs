using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    SubComplete,
    Complete
}