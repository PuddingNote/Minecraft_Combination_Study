using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public ItemSlot[] inventorySlots;
    public GameObject inventoryItemPrefab;

    public bool AddItem(Item newItem)
    {
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            ItemSlot slot = inventorySlots[i];
            InventoryItem itemInSlot = slot.GetComponentInChildren<InventoryItem>();
            if (itemInSlot == null)
            {
                SpawnNewItem(newItem, slot);
                return true;
            }
        }
        return false;
    }

    void SpawnNewItem(Item newItem, ItemSlot slot)
    {
        GameObject newItemGo = Instantiate(inventoryItemPrefab, slot.transform);
        InventoryItem inventoryItem = newItemGo.GetComponent<InventoryItem>();
        inventoryItem.InitialiseItem(newItem);
    }
}
