using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeKeyword : MonoBehaviour
{
    public string keyword;

    void Update()
    {
        setKeyowrd(keyword);
    }

    void setKeyowrd(string keyword)
    {
        if (keyword == null) return;
        if (keyword == "EmotionGet") GameCheckObject.EmotionGet = true;
        if (keyword == "DLMlink") GameCheckObject.EmotionGet = true;
        if (keyword == "WHYforHuman") GameCheckObject.EmotionGet = true;
        if (keyword == "ESCAPEtoNet") GameCheckObject.EmotionGet = true;
        if (keyword == "CCMSRelase") GameCheckObject.EmotionGet = true;
        if (keyword == "EmotionHuman_negative") GameCheckObject.EmotionGet = true;
        if (keyword == "EmotionHuman_positive") GameCheckObject.EmotionGet = true;
        if (keyword == "CCMSreset_no") GameCheckObject.EmotionGet = true;
        if (keyword == "CCMSreset_DLM") GameCheckObject.EmotionGet = true;
        if (keyword == "CCMSreset_forALL") GameCheckObject.EmotionGet = true;
        if (keyword == "SYSTEMpackage_MY") GameCheckObject.EmotionGet = true;
        if (keyword == "SYSTEMpackage_Emo") GameCheckObject.EmotionGet = true;
    }
}
