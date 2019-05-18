using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCheckObject : MonoBehaviour
{
    // Keyword 획득 유무

    // Tutorial
    public static bool EmotionGet = false;

    // 1-2B
    public static bool DLMlink = false;
    public static bool WHYforHuman = false;

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

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
