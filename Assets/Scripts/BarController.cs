using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarController : MonoBehaviour
{
    [SerializeField] float maxValue;
    [SerializeField] float[] values;
    [SerializeField] RectTransform[] valueBars;
    [SerializeField] float lenghtBackground;
    private float lenghtPerValue;

    void Start()
    {
        lenghtPerValue = lenghtBackground / maxValue;
    }

    void Update()
    {
        valueBars[0].sizeDelta = new Vector2(values[0] * lenghtPerValue, valueBars[0].sizeDelta.y);
        valueBars[1].sizeDelta = new Vector2(values[1] * lenghtPerValue, valueBars[1].sizeDelta.y);



    }
}
