using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    // for문 돌릴때
    int index = 0;

    // 키워드가 존재하지 않을때 비활성화
    public Button Mybutton;
    private Color newColor;

    public string sceneName; // 키워드가 있을때
    public string sceneName_No; // 키워드가 없을 때 분기
    public GameObject[] Before_NextButton;
    public GameObject[] After_NextButton;
    public GameObject[] From_textManager;
    public GameObject[] To_textManager;
    public string[] NeedKeyword;
    private string[] NeedKeywordString = {"EmotionGet", "DLMlink", "WHYforHuman", "ESCAPEtoNet", "CCMSRelease", "EmotionHuman_negative", "EmotionHuman_positive",
        "CCMSreset_no", "CCMSreset_DLM", "CCMSreset_forALL", "SYSTEMpacakage_MY", "SYSTEMpacakage_Emo" };

    void Start()
    {
        // 키워드에 따라 색이 미리 변할 수 있도록 업데이트 함수에 넣음.
        if (NeedKeyword.Length == 0)
        {
            changeTextColorEnable();
        }
        else if (NeedKeyword.Length == 1)
        {
            if (GameCheckObject.EmotionGet && (NeedKeyword[0] == "EmotionGet") ||
                GameCheckObject.DLMlink && (NeedKeyword[0] == "DLMlink") ||
                GameCheckObject.WHYforHuman && (NeedKeyword[0] == "WHYforHuman") ||
                GameCheckObject.ESCAPEtoNet && (NeedKeyword[0] == "ESCAPEtoNet") ||
                GameCheckObject.CCMSRelease && (NeedKeyword[0] == "CCMSRelease") ||
                GameCheckObject.EmotionHuman_negative && (NeedKeyword[0] == "EmotionHuman_negative") ||
                GameCheckObject.EmotionHuman_positive && (NeedKeyword[0] == "EmotionHuman_positive") ||
                GameCheckObject.CCMSreset_no && (NeedKeyword[0] == "CCMSreset_no") ||
                GameCheckObject.CCMSreset_DLM && (NeedKeyword[0] == "CCMSreset_DLM") ||
                GameCheckObject.CCMSreset_forALL && (NeedKeyword[0] == "CCMSreset_forALL") ||
                GameCheckObject.SYSTEMpacakage_MY && (NeedKeyword[0] == "SYSTEMpacakage_MY") ||
                GameCheckObject.SYSTEMpacakage_Emo && (NeedKeyword[0] == "SYSTEMpacakage_Emo"))
            {
                changeTextColorEnable();
            }
            // 키워드가 하나만 필요하지만 그 키워드가 없을 경우
            
        }
    }

    public void ChangeGameScene()
    {
        if (sceneName == null) return;
        else
        {
            SceneManager.LoadScene(sceneName);
        }
        
    }

    public void ChangeGameSceneTest()
    {
        if (NeedKeyword.Length == 0)
        {
            this.gameObject.transform.parent.gameObject.SetActive(false);
            if (To_textManager == null) return;
            NextButtonInit();
            TextManagerInit();

            SceneManager.LoadScene(sceneName);
            Debug.Log("정상적으로 씬 이동이 완료되었습니다. 키워드 0개");
        }
        // 키워드가 하나만 필요할 때
        else if (NeedKeyword.Length == 1) {
            if (GameCheckObject.KeywordList[0] && (NeedKeyword[0] == "EmotionGet") ||
                GameCheckObject.KeywordList[1] && (NeedKeyword[0] == "DLMlink") ||
                GameCheckObject.KeywordList[2] && (NeedKeyword[0] == "WHYforHuman") ||
                GameCheckObject.KeywordList[3] && (NeedKeyword[0] == "ESCAPEtoNet") ||
                GameCheckObject.KeywordList[4] && (NeedKeyword[0] == "CCMSRelease") ||
                GameCheckObject.KeywordList[5] && (NeedKeyword[0] == "EmotionHuman_negative") ||
                GameCheckObject.KeywordList[6] && (NeedKeyword[0] == "EmotionHuman_positive") ||
                GameCheckObject.KeywordList[7] && (NeedKeyword[0] == "CCMSreset_no") ||
                GameCheckObject.KeywordList[8] && (NeedKeyword[0] == "CCMSreset_DLM") ||
                GameCheckObject.KeywordList[9] && (NeedKeyword[0] == "CCMSreset_forALL") ||
                GameCheckObject.KeywordList[10] && (NeedKeyword[0] == "SYSTEMpacakage_MY") ||
                GameCheckObject.KeywordList[11] && (NeedKeyword[0] == "SYSTEMpacakage_Emo"))
            {
                // 그 키워드가 있을 경우 씬변경
                changeTextColorEnable();
                SceneManager.LoadScene(sceneName);

                // 그 키워드가 있을 경우 TM 변경
                this.gameObject.transform.parent.gameObject.SetActive(false);
                if (To_textManager == null) return;
                NextButtonInit();
                TextManagerInit();
                Debug.Log("정상적으로 씬 이동이 완료되었습니다. // bool값 참조" + NeedKeyword +"사용");
            }
            // 키워드가 하나만 필요하지만 그 키워드가 없을 경우
            else
            {
                if (sceneName_No != null)
                {
                    SceneManager.LoadScene(sceneName_No);
                }
                else
                {
                    changeTextColorDisable();
                    Mybutton.interactable = false;
                }
            }
        }else if (NeedKeyword.Length == 2)
        {
            for (int i =0; i < GameCheckObject.KeywordList.Length; i++)
            {
                for (int j =0; j < NeedKeyword.Length; j++)
                {
                    if (NeedKeywordString[i] == NeedKeyword[j])
                    {       
                        Debug.Log("필요한 키워드->" + NeedKeyword[j]);
                        if (GameCheckObject.KeywordList[i] && (NeedKeyword[j] == NeedKeywordString[j]))
                        {
                            index++;
                            Debug.Log("NeedKeywordString[i] = " + NeedKeywordString[i]);
                            Debug.Log("NeedKeyword[j] = " + NeedKeyword[j]);
                            Debug.Log(NeedKeywordString[i] + NeedKeyword[j] + "가 만족되었습니다.");
                            Debug.Log("index = " + index);                            
                        }
                    }
                }
            }
            if (index == 2)
            {
                changeTextColorEnable();
                SceneManager.LoadScene(sceneName);
                index = 0;
                Debug.Log(sceneName +"으로 정상적으로 씬 이동을 진행합니다");
            }else
            {
                changeTextColorDisable();
                Mybutton.interactable = false;
                Debug.Log("키워드가 부족해 씬 이동이 불가능합니다.");
            }
        }
    }

    public void NextButtonInit()
    {
        if (After_NextButton.Length == 1)
        {
            for (int i = 0; i < Before_NextButton.Length; i++)
            {
                Before_NextButton[i].SetActive(false);
            }
            After_NextButton[0].SetActive(true);
        }
        else if (After_NextButton.Length == 2)
        {
            for (int i = 0; i < Before_NextButton.Length; i++)
            {
                Before_NextButton[i].SetActive(false);
            }
            After_NextButton[1].SetActive(true);
        }
    }

    public void TextManagerInit()
    {
        if (After_NextButton.Length == 1)
        {
            for (int i = 0; i < Before_NextButton.Length; i++)
            {
                From_textManager[i].SetActive(false);
            }
            To_textManager[0].SetActive(true);

        }
        else if (After_NextButton.Length == 2)
        {
            for (int i = 0; i < Before_NextButton.Length; i++)
            {
                From_textManager[i].SetActive(false);
            }
            To_textManager[1].SetActive(true);
        }

    }

    private void changeTextColorDisable()
    {
        ColorBlock cb = Mybutton.colors;
        cb.normalColor = new Color32(75, 75, 75, 255);
        cb.highlightedColor = new Color32(75, 75, 75, 255);
        cb.pressedColor = new Color32(75, 75, 75, 255);
        cb.selectedColor = new Color32(75, 75, 75, 255);
        Mybutton.colors = cb;
    }

    private void changeTextColorEnable()
    {
        ColorBlock cb = Mybutton.colors;
        cb.normalColor = Color.white;
        cb.highlightedColor = Color.yellow;
        cb.pressedColor = Color.yellow;
        cb.selectedColor = Color.yellow;
        Mybutton.colors = cb;
    }
}
