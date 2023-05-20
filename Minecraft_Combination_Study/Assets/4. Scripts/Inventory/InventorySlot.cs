using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour, IDropHandler
{
    public Image image;

    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            InventoryItem inventoryItem = eventData.pointerDrag.GetComponent<InventoryItem>();
            inventoryItem.parentAfterDrag = transform;
        }

        /*
        InventoryItem droppedItem = eventData.pointerDrag.GetComponent<InventoryItem>();
        InventoryItem targetItem = GetComponentInChildren<InventoryItem>();

        if (targetItem != null)
        {
            // 아이템 스왑
            Transform droppedItemParent = droppedItem.transform.parent;
            Transform targetItemParent = targetItem.transform.parent;

            int droppedItemSiblingIndex = droppedItem.transform.GetSiblingIndex();
            int targetItemSiblingIndex = targetItem.transform.GetSiblingIndex();

            droppedItem.transform.SetParent(targetItemParent);
            droppedItem.transform.SetSiblingIndex(targetItemSiblingIndex);

            targetItem.transform.SetParent(droppedItemParent);
            targetItem.transform.SetSiblingIndex(droppedItemSiblingIndex);
        }
        else
        {
            droppedItem.parentAfterDrag = transform;
        }
        */
    }
}
