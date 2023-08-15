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

            switch (DragHandler.itemDragging.name)
            {
                case "GloomSymbol":
                    SymbolFunction.instance.Gloom();
                    break;
                case "GleeSymbol":
                    SymbolFunction.instance.Glee();
                    break;
            }
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
