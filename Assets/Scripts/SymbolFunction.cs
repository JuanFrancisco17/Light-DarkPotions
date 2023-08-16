using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymbolFunction : MonoBehaviour
{
    public static SymbolFunction instance;
    private bool previousDark;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void Gloom()
    {
        previousDark = true;
        BarController.instance.values[0] += 10;

        float diference = BarController.instance.values[0] + BarController.instance.values[1];
        if (diference > 100)
        {
            BarController.instance.values[1] -= (diference - 100);
        }
    }

    public void Glee()
    {
        previousDark = false;
        BarController.instance.values[1] += 10;

        float diference = BarController.instance.values[0] + BarController.instance.values[1];
        if (diference > 100)
        {
            BarController.instance.values[0] -= (diference - 100);
        }
    }

    public void Tearful()
    {
        if (previousDark)
        {
            BarController.instance.values[0] *= 2;
            float diference = BarController.instance.values[0] + BarController.instance.values[1];
            previousDark = true;
            if (diference > 100)
            {
                BarController.instance.values[1] -= (diference - 100);
            }
        }
        else
        {
            BarController.instance.values[1] *= 2;
            float diference = BarController.instance.values[0] + BarController.instance.values[1];
            previousDark = false;
            if (diference > 100)
            {
                BarController.instance.values[0] -= (diference - 100);
            }
        }
    }

    public void Angry()
    {
        previousDark = true;
        if (BarController.instance.values[0] > BarController.instance.values[1])
        {
            BarController.instance.values[0] += 30;
        }
        else
        {
            BarController.instance.values[0] += 10;
        }

        float diference = BarController.instance.values[0] + BarController.instance.values[1];
        if (diference > 100)
        {
            BarController.instance.values[1] -= (diference - 100);
        }
    }

    public void Grateful()
    {
        previousDark = false;
        if (BarController.instance.values[1] > BarController.instance.values[0])
        {
            BarController.instance.values[1] += 30;
        }
        else
        {
            BarController.instance.values[1] += 10;
        }

        float diference = BarController.instance.values[0] + BarController.instance.values[1];
        if (diference > 100)
        {
            BarController.instance.values[0] -= (diference - 100);
        }
    }

    //public void Mirror()
    //{
    //    previousDark = true;
    //    BarController.instance.values[0] += BarController.instance.values[1];

    //    float diference = BarController.instance.values[0] + BarController.instance.values[1];
    //    if (diference > 100)
    //    {
    //        BarController.instance.values[1] -= (diference - 100);
    //    }
    //}

    public void Nostalgia()
    {
        if (previousDark)
        {
            BarController.instance.values[0] += 20;
            float diference = BarController.instance.values[0] + BarController.instance.values[1];
            previousDark = true;
            if (diference > 100)
            {
                BarController.instance.values[1] -= (diference - 100);
            }
        }
        else
        {
            BarController.instance.values[1] += 20;
            float diference = BarController.instance.values[0] + BarController.instance.values[1];
            previousDark = false;
            if (diference > 100)
            {
                BarController.instance.values[0] -= (diference - 100);
            }
        }
    }

    public void Anxious()
    {
        previousDark = false;
        BarController.instance.values[1] /= 2;

        float diference = BarController.instance.values[0] + BarController.instance.values[1];
        if (diference > 100)
        {
            BarController.instance.values[0] -= (diference - 100);
        }
    }

    public void Tranquil()
    {
        previousDark = false;
        BarController.instance.values[0] /= 2;

        float diference = BarController.instance.values[0] + BarController.instance.values[1];
        if (diference > 100)
        {
            BarController.instance.values[1] -= (diference - 100);
        }
    }

    public void Astray()
    {
        previousDark = true;
        BarController.instance.values[0] -= 10;

        float diference = BarController.instance.values[0] + BarController.instance.values[1];
        if (diference > 100)
        {
            BarController.instance.values[1] -= (diference - 100);
        }
    }

    public void Recoup()
    {
        previousDark = false;
        BarController.instance.values[1] -= 10;

        float diference = BarController.instance.values[0] + BarController.instance.values[1];
        if (diference > 100)
        {
            BarController.instance.values[0] -= (diference - 100);
        }
    }

    public void Envy()
    {
        previousDark = true;
        BarController.instance.values[0] += BarController.instance.values[1];
        //BarController.instance.values[1] -= BarController.instance.values[1];

        float diference = BarController.instance.values[0] + BarController.instance.values[1];
        if (diference > 100)
        {
            BarController.instance.values[1] -= (diference - 100);
        }
    }
}
