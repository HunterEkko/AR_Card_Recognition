using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test_btn : MonoBehaviour
{
    [SerializeField] GameObject MainPage,TrianglePage,CirclePage,RectanglePage;
    public void backClick()
    {
        if(MainPage.activeSelf)
        {
            SceneManager.LoadSceneAsync("Menu", LoadSceneMode.Single);
        }
        else
        {
            TrianglePage.SetActive(false);
            CirclePage.SetActive(false);
            RectanglePage.SetActive(false);
            MainPage.SetActive(true);
        }
    }
    public void TriangleClick()
    {
        MainPage.SetActive(false);
        TrianglePage.SetActive(true);
    }
    public void CircleClick()
    {
        MainPage.SetActive(false);
        CirclePage.SetActive(true);
    }
    public void RectangleClick()
    {
        MainPage.SetActive(false);
        RectanglePage.SetActive(true);
    }
}
