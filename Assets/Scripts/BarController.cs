using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarController : MonoBehaviour
{
    public static BarController instance;
    [SerializeField] float maxValue;
    public float[] values;
    [SerializeField] RectTransform[] valueBars;
    [SerializeField] float lenghtBackground;
    private float lenghtPerValue;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        lenghtPerValue = lenghtBackground / maxValue;
    }

    void Update()
    {

        valueBars[0].sizeDelta = new Vector2(values[0] * lenghtPerValue, valueBars[0].sizeDelta.y);
        valueBars[1].sizeDelta = new Vector2(values[1] * lenghtPerValue, valueBars[1].sizeDelta.y);

        if (values[0] > 100)
        {
            values[0] = 100;
        }
        else if (values[1] > 100)
        {
            values[1] = 100;
        }

        if (values[0] < 0)
        {
            values[0] = 0;
        }
        else if (values[1] < 0)
        {
            values[1] = 0;
        }
    }
}
