using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorials : MonoBehaviour
{
    public GameObject toggleObject;
    private bool objectActive = false;

    void Start()
    {
        // Ensure the GameObject is initially deactivated.
        toggleObject.SetActive(false);
    }

    public void ToggleObject()
    {
        // Toggle the GameObject's activity.
        objectActive = !objectActive;
        toggleObject.SetActive(objectActive);
    }
}
