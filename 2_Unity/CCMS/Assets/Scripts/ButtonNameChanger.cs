using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonNameChanger : MonoBehaviour
{
    public TextMeshProUGUI[] buttonName;
    [TextArea]
    public string[] buttonNameValue;

    void ButtonNameChange()
    {
        for (int i = 0; i < buttonNameValue.Length; i++) {
            buttonName[i].text = buttonNameValue[i];
        }
    }

    

    void Scene()
    {
    }

    void Start()
    {
        ButtonNameChange();
    }
}
