using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Recipe", menuName = "Scriptable object/Recipes", order = int.MaxValue)]
public class Recipe : ScriptableObject
{
    public Item[] topRow = new Item[3];
    public Item[] midRow = new Item[3];
    public Item[] bottomRow = new Item[3];

    public Item output;
}