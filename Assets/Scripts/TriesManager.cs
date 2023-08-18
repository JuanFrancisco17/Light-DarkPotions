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
    [SerializeField] GameObject winPanel;
    [SerializeField] GameObject losePanel;

    private void Start()
    {
        winPanel.SetActive(false); //Sets Win Panel To False
        losePanel.SetActive(false); //Sets Lose Panel To Flase
    }

    void Update()
    {
        if (tries == 0 && BarController.instance.values[0] == winDark && BarController.instance.values[1] == winLight)
        {
            isWin = true;
        }

        if (tries == 0 && isWin)
        {
            Debug.Log("You have won"); //Debugging...
            winPanel.SetActive(true); //We Have Won!
        }
        else if (tries == 0 && isWin == false)
        {
            Debug.Log("You have lost"); //Debugging...
            losePanel.SetActive(true); //We Have Lost!
        }
    }

    public void SubstractTries()
    {
        tries--;
        text.text = "" + tries;
    }
}
