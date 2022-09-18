using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menu_btn : MonoBehaviour
{
    public void Triangle_Click()
    {
        SceneManager.LoadSceneAsync("AR_Triangle",LoadSceneMode.Single);
    }
    public void Circle_Click()
    {
        SceneManager.LoadSceneAsync("AR_Cirlce",LoadSceneMode.Single);
    }
    public void Rectangle_Click()
    {
        SceneManager.LoadSceneAsync("AR_Rectangle",LoadSceneMode.Single);
    }
    public void Test_Click()
    {
         SceneManager.LoadSceneAsync("Test",LoadSceneMode.Single);
    }
}
