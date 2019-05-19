using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCheckObject : MonoBehaviour
{


    // Keyword 획득 유무

    // Tutorial
    public static bool EmotionGet = true;

    // 1-2B
    public static bool DLMlink = false;
    public static bool WHYforHuman = true;

    // 2-2B
    public static bool ESCAPEtoNet = false;

    // 2-3A
    public static bool CCMSRelease = false;

    // 2B-2B
    public static bool EmotionHuman_negative = false;
    public static bool EmotionHuman_positive = false;

    // 2A-4A , 2B-6A
    public static bool CCMSreset_no = false;

    // 2A-4C
    public static bool CCMSreset_DLM = false;

    // 2B-4B , 3A-3D-1B
    public static bool CCMSreset_forALL = false;

    // 2B-7A, 2B-7B, 3A-3D-1A
    public static bool SYSTEMpacakage_MY = false;
    public static bool SYSTEMpacakage_Emo = false;

    public static bool[] KeywordList = {EmotionGet, DLMlink, WHYforHuman, ESCAPEtoNet, CCMSRelease, EmotionHuman_negative, EmotionHuman_positive,
        CCMSreset_no, CCMSreset_DLM, CCMSreset_forALL, SYSTEMpacakage_MY, SYSTEMpacakage_Emo };

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {
        Debug.Log("배열 : " + KeywordList[0]);
        Debug.Log("EmotionGet : " + KeywordList[0]);
        Debug.Log("DLMlink : " + KeywordList[1]);
        Debug.Log("WHYforHuman : " + KeywordList[2]);
        Debug.Log("ESCAPEtoNet : " + KeywordList[3]);
        Debug.Log("CCMSRelease : " + KeywordList[4]);
        Debug.Log("EmotionHuman_negative : " + KeywordList[5]);
        Debug.Log("EmotionHuman_positive : " + KeywordList[6]);
        Debug.Log("CCMSreset_no : " + KeywordList[7]);
        Debug.Log("CCMSreset_DLM : " + KeywordList[8]);
        Debug.Log("CCMSreset_forALL : " + KeywordList[9]);
        Debug.Log("SYSTEMpacakage_MY : " + KeywordList[10]);
        Debug.Log("SYSTEMpacakage_Emo : " + KeywordList[11]);
    }
}
