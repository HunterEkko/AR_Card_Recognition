using UnityEngine;
using Vuforia;
public class startAR : MonoBehaviour
{
    void Start()
    {
        VuforiaRuntime.Instance.InitVuforia();
    }
}
