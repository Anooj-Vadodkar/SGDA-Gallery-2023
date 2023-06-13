using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtDescription : MonoBehaviour
{
    public GameObject descriptionUI;
    // Assign UI element here.

    private bool enteredPaintingRange = false;

    private void Update()
    {
        if (enteredPaintingRange && Input.GetKeyDown(KeyCode.E))
        {
            descriptionUI.SetActive(!descriptionUI.activeInHierarchy);
        }
    }
    private void OnTriggerEnter()
    {
        enteredPaintingRange = true;
    }

    private void OnTriggerExit()
    {
        enteredPaintingRange = false;
        descriptionUI.SetActive(false);
    }
}
