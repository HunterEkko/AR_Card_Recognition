using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class SingleUISwitch : MonoBehaviour
{
    public TrackableStatusManager TSM;
    public GameObject UI;
    private bool isOpenUI = false;
    private GameObject AR;
    void Start()
    {
        AR = GameObject.Find("ARManager");
    }
    void Update()
    {
        if (TSM.Status == TrackableStatusManager.TurnStates.TRACK)
        {
            UI.SetActive(true);
            AR.GetComponent<ARManager>().AR_close();
        }
        else
        {
            UI.SetActive(false);
        }
    }
}
