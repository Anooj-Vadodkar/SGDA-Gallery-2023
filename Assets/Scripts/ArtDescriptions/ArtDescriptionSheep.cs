using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ArtDescriptionSheep : MonoBehaviour
{
    public GameObject descriptionUI;
    public TMP_Text learnMore;
    // Assign UI element here.

    private bool enteredPaintingRange = false;

    private void Update()
    {
        if (enteredPaintingRange && Input.GetKeyDown(KeyCode.E))
        {
            descriptionUI.SetActive(!descriptionUI.activeInHierarchy);
            // This is essentially just checking if the description UI is active; if it is, then get rid of the click e to learn more text. If it isn't, bring it back.
            learnMore.text = descriptionUI.activeInHierarchy ? "" : "Click E To Talk To The Manager!";
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
        learnMore.text = "Click E To Talk To The Manager!";
    }
}
