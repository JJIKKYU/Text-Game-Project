using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string sceneName;
    public GameObject[] selectButton;
    public string[] select;
    private string ButtonName;

    private void Awake()
    {
    }

    public void ChangeGameScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void KeywordBoolChanger()
    {
        GameCheckObject.EmotionGet = true;
    }
}
