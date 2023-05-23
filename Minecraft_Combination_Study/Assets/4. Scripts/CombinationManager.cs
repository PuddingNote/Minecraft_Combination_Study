using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombinationManager : MonoBehaviour
{
    public ItemSlot[] topRow = new ItemSlot[3];
    public ItemSlot[] midRow = new ItemSlot[3];
    public ItemSlot[] bottomRow = new ItemSlot[3];

    public ItemSlot outputSlot;

    private List<ItemSlot[]> allSlots = new List<ItemSlot[]>();

    public List<Recipe> recipes = new List<Recipe>();

    private void Awake()
    {
        allSlots.Add(topRow);
        allSlots.Add(midRow);
        allSlots.Add(bottomRow);

        recipes.AddRange(Resources.LoadAll<Recipe>("Recipes/"));
    }

    private void Update()
    {
        foreach (Recipe recipe in recipes)
        {
            bool correctPlacement = true;

            List<Item[]> allRecipeSlots = new List<Item[]>();
            allRecipeSlots.Add(recipe.topRow);
            allRecipeSlots.Add(recipe.midRow);
            allRecipeSlots.Add(recipe.bottomRow);

            for (int i = 0; i < 3; i++)
            {
                for (int n = 0; n < allRecipeSlots[i].Length; n++)
                {
                    if (allRecipeSlots[i][n] != null)
                    {
                        if (allSlots[i][n].currItem != null)
                        {
                            if (allRecipeSlots[i][n].itemId != allSlots[i][n].currItem.itemId)
                            {
                                correctPlacement = false;
                            }
                        }
                        else
                        {
                            correctPlacement = false;
                        }
                    }
                    else
                    {
                        if (allSlots[i][n].currItem != null)
                        {
                            correctPlacement = false;
                            continue;
                        }
                    }
                }
            }

            if (correctPlacement)
            {
                // 결과물슬롯 변화
                // 결과물슬롯의 자식오브젝트에 recipe.outpt의 InventoryItem을 추가
                // 결과물슬롯의 아이템을 드래그 앤 드랍 하면 현재 조합대에있는 아이템들 삭제
                break;
            }
            else
            {
                // 결과물슬롯 변화 없음
            }
        }
    }

}