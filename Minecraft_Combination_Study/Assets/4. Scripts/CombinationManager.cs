using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombinationManager : MonoBehaviour
{
    public InventorySlot[] topRow;
    public InventorySlot[] midRow;
    public InventorySlot[] bottomRow;

    private List<InventorySlot[]> allSlots = new List<InventorySlot[]>();

    public InventorySlot outputSlot;

    private List<Recipe> recipes = new List<Recipe>();

    private void Awake()
    {
        recipes.AddRange(Resources.LoadAll<Recipe>("Recipes/"));
    }

    void Update()
    {
        //foreach (Recipe recipe in recipes)
        //{
        //    bool correctPlacement = true;

        //    List<Item[]> allRecipeSlots = new List<Item[]>();
        //    allRecipeSlots.Add(recipe.topRow);
        //    allRecipeSlots.Add(recipe.midRow);
        //    allRecipeSlots.Add(recipe.bottomRow);

        //    for (int i = 0; i < 3; i++)
        //    {
        //        for (int n = 0; n < allRecipeSlots[i].Length; n++)
        //        {
        //            if (allRecipeSlots[i][n] != null)
        //            {
        //                if (allSlots[i][n].currItem != null)
        //                {
        //                    if (allRecipeSlots[i][n].itemId != allSlots[i][n].currItem.itemId)
        //                    {
        //                        correctPlacement = false;
        //                    }
        //                }
        //                else
        //                {
        //                    correctPlacement = false;
        //                }
        //            }
        //            else
        //            {
        //                if (allSlots[i][n].currItem != null)
        //                {
        //                    correctPlacement = false;
        //                    continue;
        //                }
        //            }
        //        }
        //    }

        //    if (correctPlacement)
        //    {
        //        outputSlot.currItem = recipe.output;
        //        outputSlot.UpdateSlotData();
        //        break;
        //    }
        //    else
        //    {
        //        outputSlot.currItem = null;
        //        outputSlot.UpdateSlotData();
        //    }
        //}
    }

}