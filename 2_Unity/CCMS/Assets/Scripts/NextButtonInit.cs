using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButtonInit : MonoBehaviour
{
    public GameObject[] button;
    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i < button.Length; i++)
        {
            button[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
