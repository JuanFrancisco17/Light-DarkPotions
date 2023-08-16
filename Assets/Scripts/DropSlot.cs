using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropSlot : MonoBehaviour, IDropHandler
{
    private GameObject item;
    private TriesManager triesManager;

    private void Start()
    {
        triesManager = GameObject.Find("GameManager").GetComponent<TriesManager>();   
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            item = DragHandler.itemDragging;
            item.transform.SetParent(DragHandler.startParent);
            item.transform.position = DragHandler.startPosition;
            //Destroy(item.gameObject);

            switch (DragHandler.itemDragging.name)
            {
                case "GloomSymbol":
                    triesManager.SubstractTries();
                    SymbolFunction.instance.Gloom();
                    break;
                case "GleeSymbol":
                    triesManager.SubstractTries();
                    SymbolFunction.instance.Glee();
                    break;
                case "TearfulSymbol":
                    triesManager.SubstractTries();
                    SymbolFunction.instance.Tearful();
                    break;
                case "AngrySymbol":
                    triesManager.SubstractTries();
                    SymbolFunction.instance.Angry();
                    break;
                case "GratefulSymbol":
                    triesManager.SubstractTries();
                    SymbolFunction.instance.Grateful();
                    break;
                //case "MirrorSymbol":
                //    triesManager.SubstractTries();
                //    SymbolFunction.instance.Mirror();
                //    break;
                case "NostalgiaSymbol":
                    triesManager.SubstractTries();
                    SymbolFunction.instance.Nostalgia();
                    break;
                case "AnxiousSymbol":
                    triesManager.SubstractTries();
                    SymbolFunction.instance.Anxious();
                    break;
                case "TranquilSymbol":
                    triesManager.SubstractTries();
                    SymbolFunction.instance.Tranquil();
                    break;
                case "AstraySymbol":
                    triesManager.SubstractTries();
                    SymbolFunction.instance.Astray();
                    break;
                case "RecoupSymbol":
                    triesManager.SubstractTries();
                    SymbolFunction.instance.Recoup();
                    break;
                case "EnvySymbol":
                    triesManager.SubstractTries();
                    SymbolFunction.instance.Envy();
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
