using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TrackableStatusManager TSM;
    public GameObject UICanvas;
    private bool isOpen = false;
    // Update is called once per frame
    void Update()
    {
        if (TSM.Status == TrackableStatusManager.TurnStates.TRACK)
        {
            UICanvas.SetActive(true);
        }
        else
        {
            UICanvas.SetActive(false);
        }
    }
}
