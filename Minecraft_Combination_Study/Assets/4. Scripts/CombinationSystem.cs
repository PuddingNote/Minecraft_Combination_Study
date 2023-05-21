using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombinationSystem : MonoBehaviour
{
    public GameObject[] itemSlots; // 3x3 ���� �迭
    public GameObject resultSlot; // ��� ����

    private bool CanCombine()
    {
        // ��� ������ ä���� �ִ��� Ȯ��
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

        // ���Կ� �ִ� �����۵��� Ȯ���ϰ� ���� ��� ó��
        List<GameObject> items = new List<GameObject>();

        foreach (GameObject slot in itemSlots)
        {
            GameObject item = slot.transform.GetChild(0).gameObject;
            items.Add(item);
        }

        // �����۵��� �����Ͽ� ��� ������ ���� �Ǵ� ���׷��̵�
        GameObject resultItem = Combine(items);

        // ��� ���Կ� ��� ������ ��ġ
        PlaceResultItem(resultItem);

        // ���� ����
        ClearSlots();
    }

    private GameObject Combine(List<GameObject> items)
    {
        // ������ ���� ���� ����
        // �Էµ� �����۵��� �м��ϰ� ���ο� �������� �����ϰų� ���� �������� ���׷��̵�
        // ������ ���� ������ �����ؾ� �մϴ�.
        // ���⿡���� ������ ù ��° �������� ����Ͽ� ��� ������ �����ϴ� ���ø� �����մϴ�.

        GameObject firstItem = items[0];
        GameObject resultItem = Instantiate(firstItem);

        return resultItem;
    }

    private void PlaceResultItem(GameObject item)
    {
        // ��� ���Կ� ��� ������ ��ġ
        item.transform.SetParent(resultSlot.transform);
        item.transform.localPosition = Vector3.zero;
    }

    private void ClearSlots()
    {
        // ��� ���� ����
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
