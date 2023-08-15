using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropSlot : MonoBehaviour, IDropHandler
{
    public GameObject item;

    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            item = DragHandler.itemDragging;
            item.transform.SetParent(DragHandler.startParent);
            item.transform.position = DragHandler.startPosition;
            Debug.Log(DragHandler.itemDragging.name);
        }
    }

    void Update()
    {
        if (item != null && item.transform.parent != transform.parent)
        {
            item = null;
        }
    }
}
