using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Scriptable object/Items", order = int.MaxValue)]
public class Item : ScriptableObject
{
    public int itemId;
    public Sprite itemImage;
}