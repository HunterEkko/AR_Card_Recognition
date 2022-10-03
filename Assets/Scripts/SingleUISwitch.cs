using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class SingleUISwitch : MonoBehaviour
{
    public TrackableStatusManager TSM;
    public GameObject UI;
    private bool isOpenUI = false;
    void Update()
    {
        if (TSM.Status == TrackableStatusManager.TurnStates.TRACK)
        {
            UI.SetActive(true);
        }
        else
        {
            UI.SetActive(false);
        }
    }
}
