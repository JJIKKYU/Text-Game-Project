using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class NextButton : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
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

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (index == next.Length-1)
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
    }
}
