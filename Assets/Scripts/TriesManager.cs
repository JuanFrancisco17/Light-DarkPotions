using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TriesManager : MonoBehaviour
{
    public int tries = 5;
    [SerializeField] TMP_Text text;
    [SerializeField] float winDark;
    [SerializeField] float winLight;
    public bool isWin = false;
    [SerializeField] GameObject panel;

    private void Start()
    {
        panel.SetActive(false); 
    }

    void Update()
    {
        if (tries == 0 && BarController.instance.values[0] == winDark && BarController.instance.values[1] == winLight)
        {
            isWin = true;
        }

        if (tries == 0 && isWin)
        {
            panel.SetActive(true);
        }
        else if (tries == 0 && isWin == false)
        {
            Debug.Log("You have lost");
        }
    }

    public void SubstractTries()
    {
        tries--;
        text.text = "" + tries;
    }
}
