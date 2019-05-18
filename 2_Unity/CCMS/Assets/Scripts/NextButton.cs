using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class NextButton : MonoBehaviour
{
    // 다이얼로그가 마지막이라는 것 체크
    public static bool lastDialog = false;

    // 마지막에 꺼지면서 다음 버튼에게 토스할 버튼
    public GameObject[] next;
    public GameObject[] Button;
    int index = 0;

    private void Awake()
    {
        for (int i = 1; i < next.Length; i++)
        {
            next[i].GetComponent<Dialog>().enabled = false;
        }
        for (int i = 0; i < Button.Length; i++)
        {
            Button[i].SetActive(false);
        }
    }

    private void Start()
    {
        lastDialog = false;
    }

    void Update()
    {
        Debug.Log(index);
        Debug.Log(lastDialog);
        if (index == next.Length-1 && Dialog.checkButton == true)
        {
            for (int i = 0; i < Button.Length; i++)
            {
                Button[i].SetActive(true);
            }
            this.gameObject.SetActive(false);
        }
    }
    public void nextScene()
    { 
        next[index].GetComponent<Dialog>().enabled = false;
        index++;
        next[index].GetComponent<Dialog>().enabled = true;
        
        if (next.Length == index)
        {
            this.gameObject.SetActive(false);           
        }
        if (next.Length-1 == index)
        {
            
            lastDialog = true;
        }
    }
}
