using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleUISwitch : MonoBehaviour
{
     public TrackableStatusManager TSM;
    public GameObject UI;
    // Update is called once per frame
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
