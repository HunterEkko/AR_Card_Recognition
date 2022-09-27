using UnityEngine;
using Vuforia;
public class startAR : MonoBehaviour
{
    void Start()
    {
        //實例化AR
        VuforiaRuntime.Instance.InitVuforia();
    }

    public void AR_open()
    {
        VuforiaBehaviour.Instance.enabled = true;
    }
    public void AR_close()
    {
        VuforiaBehaviour.Instance.enabled = false;
    }
}
