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
        if (keyword == "EmotionGet") GameCheckObject.KeywordList[0] = true;
        if (keyword == "DLMlink") GameCheckObject.KeywordList[1] = true;
        if (keyword == "WHYforHuman") GameCheckObject.KeywordList[2] = true;
        if (keyword == "ESCAPEtoNet") GameCheckObject.KeywordList[3] = true;
        if (keyword == "CCMSRelase") GameCheckObject.KeywordList[4] = true;
        if (keyword == "EmotionHuman_negative") GameCheckObject.KeywordList[5] = true;
        if (keyword == "EmotionHuman_positive") GameCheckObject.KeywordList[6] = true;
        if (keyword == "CCMSreset_no") GameCheckObject.KeywordList[7] = true;
        if (keyword == "CCMSreset_DLM") GameCheckObject.KeywordList[8] = true;
        if (keyword == "CCMSreset_forALL") GameCheckObject.KeywordList[9] = true;
        if (keyword == "SYSTEMpackage_MY") GameCheckObject.KeywordList[10] = true;
        if (keyword == "SYSTEMpackage_Emo") GameCheckObject.KeywordList[11] = true;
    }
}
