using UnityEngine;
using Vuforia;
public class ARManager : MonoBehaviour
{
    [SerializeField] private GameObject BackAR_Btn, Main_Btn;
    void Start()
    {
        //實例化AR
        VuforiaRuntime.Instance.InitVuforia();
    }

    public void AR_open()
    {
        Main_Btn.SetActive(true);
        BackAR_Btn.SetActive(false);
    }
    public void AR_close()
    {
        Main_Btn.SetActive(false);
        BackAR_Btn.SetActive(true);
    }
}
