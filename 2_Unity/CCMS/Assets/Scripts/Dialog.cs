using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    [TextArea]
    public string[] sentences;
    private int index;
    public float typingSpeed = 0.0005f;
    public float waitingTime;
    public GameObject gameStart;
    bool ok = true;

    void Start()
    {
        textDisplay.text = "";
        gameStart.SetActive(false);
        // 오프닝 특성상 딜레이 설정
        Invoke("startText", waitingTime);
    }

    void startText()
    {
        StartCoroutine(Type());
    }

    void Update()
    {
        Debug.Log("index : " + index);
        Debug.Log("Length : " + sentences.Length);
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
                if (sentences.Length - 1 == index)
                {
                    typingSpeed = 0.00001f;
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
            }
        }
    }
}