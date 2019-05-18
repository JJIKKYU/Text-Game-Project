using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog : MonoBehaviour
{
    // 버튼 이름 관련
    public TextMeshProUGUI buttonName;
    [TextArea]
    public string buttonNameValue;
    public GameObject gameStart;

    // 본문 관련
    public TextMeshProUGUI textDisplay;
    [TextArea]
    public string[] sentences;

    // 선택 버튼 활성화 관련
    static public bool checkButton = false;

    private int index;
    public float typingSpeed = 0.0005f;
    public float waitingTime; 
    bool ok = true;

    void Start()
    {
        init();
        setButton();
        Invoke("startText", waitingTime);
    }

    void init()
    {
        textDisplay.text = "";
        gameStart.SetActive(false);
    }


    void setButton()
    {
        if (buttonName.text == null) buttonName.text = " ";
        buttonName.text = buttonNameValue;
    }

    void startText()
    {
        StartCoroutine(Type());
    }

    void Update()
    {
    }

    IEnumerator Type()
    {
        int check = 0;
        foreach (char letter in sentences[index].ToCharArray())
        {
            check++;
            if (ok == true)
            {
                textDisplay.text += letter;
                yield return new WaitForSeconds(typingSpeed);
                if (check == sentences[index].Length && sentences.Length - 1 != index)
                {
                    index++;
                    textDisplay.text += '\n';
                    startText();
                }
                if (NextButton.lastDialog == true && textDisplay.text == sentences[index])
                {
                    checkButton = true;
                }
                if (check == sentences[index].Length)
                {
                    gameStart.SetActive(true);
                }

                if (Input.GetMouseButton(0))
                {
                    StopAllCoroutines();
                    ok = false;
                }
            }
            // 마우스 클릭했을 경우 전문이 나오고 Type은 정지
            else
            {
                textDisplay.text = "";
                for (int i = 0; i < sentences.Length; i++)
                {
                    gameStart.SetActive(true);
                    textDisplay.text += sentences[i] + '\n';
                }
                if (NextButton.lastDialog == true)
                {
                    checkButton = true;
                }
            }
        }
    }
}