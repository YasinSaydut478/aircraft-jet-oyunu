using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelKilit : MonoBehaviour
{
    public static bool seviye1, seviye2, seviye3, seviye4,seviye5,seviye6,seviye7,seviye8,seviye9,seviye0;

    public Button seviye1_button, seviye2_button, seviye3_button,seviye4_button,seviye5_button,seviye6_button,seviye7_button,seviye8_button,seviye9_button,seviye10_button;
    private void Start()
    {
        seviye1 = true;
    }
    private void Update()
    {
        if (seviye2 == true)
        {
            seviye2_button.interactable = true;
        }
        if (seviye3 == true)
        {
            seviye3_button.interactable = true;
        }
        if (seviye4 == true)
        {
            seviye4_button.interactable = true;
        }
        if (seviye5 == true)
        {
            seviye5_button.interactable = true;
        }
        if (seviye6 == true)
        {
            seviye6_button.interactable = true;
        }
        if (seviye7 == true)
        {
            seviye7_button.interactable = true;
        }
        if (seviye8 == true)
        {
            seviye8_button.interactable = true;
        }
        if (seviye9 == true)
        {
            seviye9_button.interactable = true;
        }
        if (seviye0 == true)
        {
            seviye10_button.interactable = true;
        }
    }

}
