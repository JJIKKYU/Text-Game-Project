using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneChanger : MonoBehaviour
{
    public string sceneName;
    public GameObject[] Before_NextButton;
    public GameObject After_NextButton;
    public GameObject[] From_textManager;
    public GameObject To_textManager;

    public void ChangeGameScene()
    {
        if (sceneName == null) return;
        else
        {
            SceneManager.LoadScene(sceneName);
        }
        
    }

    public void ChangeGameChapter()
    {
        this.gameObject.transform.parent.gameObject.SetActive(false);
        if (To_textManager == null) return;
        NextButtonInit();
        TextManagerInit();
    }


    public void NextButtonInit()
    {
        for (int i = 0; i < Before_NextButton.Length; i++)
        {
            Before_NextButton[i].SetActive(false);
        }
        After_NextButton.SetActive(true);
    }

    public void TextManagerInit()
    {
        for (int i = 0; i < Before_NextButton.Length; i++)
        {
            From_textManager[i].SetActive(false);
        }
        To_textManager.SetActive(true);
    }
}
