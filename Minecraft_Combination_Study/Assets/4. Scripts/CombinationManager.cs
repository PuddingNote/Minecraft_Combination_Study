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
                // ��������� ��ȭ
                // ����������� �ڽĿ�����Ʈ�� recipe.outpt�� InventoryItem�� �߰�
                // ����������� �������� �巡�� �� ��� �ϸ� ���� ���մ뿡�ִ� �����۵� ����
                break;
            }
            else
            {
                // ��������� ��ȭ ����
            }
        }
    }

}