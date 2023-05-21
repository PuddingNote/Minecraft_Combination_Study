using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombinationSystem : MonoBehaviour
{
    public GameObject[] itemSlots; // 3x3 슬롯 배열
    public GameObject resultSlot; // 결과 슬롯

    private bool CanCombine()
    {
        // 모든 슬롯이 채워져 있는지 확인
        foreach (GameObject slot in itemSlots)
        {
            if (slot.transform.childCount == 0)
                return false;
        }

        return true;
    }

    private void CombineItems()
    {
        if (!CanCombine())
            return;

        // 슬롯에 있는 아이템들을 확인하고 조합 결과 처리
        List<GameObject> items = new List<GameObject>();

        foreach (GameObject slot in itemSlots)
        {
            GameObject item = slot.transform.GetChild(0).gameObject;
            items.Add(item);
        }

        // 아이템들을 조합하여 결과 아이템 생성 또는 업그레이드
        GameObject resultItem = Combine(items);

        // 결과 슬롯에 결과 아이템 배치
        PlaceResultItem(resultItem);

        // 슬롯 비우기
        ClearSlots();
    }

    private GameObject Combine(List<GameObject> items)
    {
        // 아이템 조합 로직 구현
        // 입력된 아이템들을 분석하고 새로운 아이템을 생성하거나 기존 아이템을 업그레이드
        // 적절한 조합 로직을 구현해야 합니다.
        // 여기에서는 간단히 첫 번째 아이템을 사용하여 결과 아이템 생성하는 예시를 제시합니다.

        GameObject firstItem = items[0];
        GameObject resultItem = Instantiate(firstItem);

        return resultItem;
    }

    private void PlaceResultItem(GameObject item)
    {
        // 결과 슬롯에 결과 아이템 배치
        item.transform.SetParent(resultSlot.transform);
        item.transform.localPosition = Vector3.zero;
    }

    private void ClearSlots()
    {
        // 모든 슬롯 비우기
        foreach (GameObject slot in itemSlots)
        {
            if (slot.transform.childCount > 0)
            {
                GameObject item = slot.transform.GetChild(0).gameObject;
                Destroy(item);
            }
        }
    }

    public void OnCombineButtonClicked()
    {
        CombineItems();
    }
}
