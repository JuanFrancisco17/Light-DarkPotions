using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymbolFunction : MonoBehaviour
{
    public static SymbolFunction instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void Gloom()
    {
        BarController.instance.values[0] += 10;

        float diference = BarController.instance.values[0] + BarController.instance.values[1];
        if (diference > 100)
        {
            BarController.instance.values[1] -= (diference - 100);
        }
    }

    public void Glee()
    {
        BarController.instance.values[1] += 10;

        float diference = BarController.instance.values[0] + BarController.instance.values[1];
        if (diference > 100)
        {
            BarController.instance.values[0] -= (diference - 100);
        }
    }
}
