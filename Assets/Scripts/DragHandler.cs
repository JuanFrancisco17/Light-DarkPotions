using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
    [SerializeField] private Canvas canvas;
    private RectTransform rectTransform;
    public static Vector3 startPosition;
    public static Transform startParent;
    private Transform dragParent;
    public static GameObject itemDragging;
    private CanvasGroup canvasGroup;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();

        dragParent = GameObject.FindGameObjectWithTag("DragParent").transform;
        startParent = GameObject.Find("ItemPoolBackground").transform;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        itemDragging = gameObject;
        startPosition = transform.position;
        transform.SetParent(dragParent);
        canvasGroup.alpha = 0.6f;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        itemDragging = null;
        canvasGroup.blocksRaycasts = true;
        canvasGroup.alpha = 1f;

        if (transform.parent == dragParent)
        {
            transform.position = startPosition;
            transform.SetParent(startParent);
        }
    }
}
