using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menu_btn : MonoBehaviour
{
    public void Triangle_Click()
    {
        SceneManager.LoadSceneAsync("AR_Triangle",LoadSceneMode.Single);
        Debug.Log("t");
    }
    public void Circle_Click()
    {
        SceneManager.LoadSceneAsync("AR_Cirlce",LoadSceneMode.Single);
        Debug.Log("c");
    }
    public void Rectangle_Click()
    {
        SceneManager.LoadSceneAsync("AR_Rectangle",LoadSceneMode.Single);
        Debug.Log("r");
    }
    public void Test_Click()
    {
        Debug.Log("test!!");
    }
}
