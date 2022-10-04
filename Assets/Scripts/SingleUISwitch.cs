using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class SingleUISwitch : MonoBehaviour
{
    public TrackableStatusManager TSM;
    public GameObject UI;
    public bool OpenUI = false;
    void Update()
    {
        if (TSM.Status == TrackableStatusManager.TurnStates.TRACK && !OpenUI)
        {
            OpenUI = true;
            UI.transform.parent.Find("Show_UI_Btn").gameObject.SetActive(true);
            // UI.SetActive(true);
            // UI.transform.parent.Find("White_BG").gameObject.SetActive(true);
        }
        else if (TSM.Status == TrackableStatusManager.TurnStates.LOST && OpenUI)
        {
            OpenUI = false;
            UI.SetActive(false);
            UI.transform.parent.Find("Show_UI_Btn").gameObject.SetActive(false);
        }
    }
}
