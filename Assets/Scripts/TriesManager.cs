using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TriesManager : MonoBehaviour
{
    public int tries = 5;
    [SerializeField] TMP_Text text;

    public void SubstractTries()
    {
        tries--;
        text.text = "" + tries;

        if (tries == 0)
        {
            Debug.Log("You have Lost");
        }
    }
}
