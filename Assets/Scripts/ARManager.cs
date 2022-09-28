using UnityEngine;
using Vuforia;
public class ARManager : MonoBehaviour
{
    [SerializeField] private GameObject background, BackAR_Btn, Main_Btn;
    void Start()
    {
        //實例化AR
        VuforiaRuntime.Instance.InitVuforia();
    }

    public void AR_open()
    {
        background.SetActive(false);
        Main_Btn.SetActive(true);
        BackAR_Btn.SetActive(false);
        VuforiaBehaviour.Instance.enabled = true;
    }
    public void AR_close()
    {
        background.SetActive(true);
        Main_Btn.SetActive(false);
        BackAR_Btn.SetActive(true);
        VuforiaBehaviour.Instance.enabled = false;
    }
}
