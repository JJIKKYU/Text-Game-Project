using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonChager : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    [TextArea]
    public string sentences;

    void Start()
    {
    }

    void startText()
    {
        textDisplay.text = "";
        for (int i = 0; i < sentences.Length; i++)
        {

            textDisplay.text += sentences[i];
        }
    }
}