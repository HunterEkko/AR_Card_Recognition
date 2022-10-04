using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show_UI_Manager : MonoBehaviour
{
    [SerializeField] GameObject[] Manager;
    public void Show_UI_Click()
    {
        foreach(GameObject M in Manager)
        {
            SingleUISwitch SUI = M.GetComponent<SingleUISwitch>();
            if(SUI.OpenUI)
            {
                SUI.TSM.gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
                SUI.UI.SetActive(true);
                SUI.UI.transform.parent.Find("Show_UI_Btn").gameObject.SetActive(false);
                break;
            }
        }
    }
}
