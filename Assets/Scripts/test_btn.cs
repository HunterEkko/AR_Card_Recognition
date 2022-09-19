using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class test_btn : MonoBehaviour
{

    [SerializeField] GameObject MainPage, TrianglePage, CirclePage, RectanglePage;
    [SerializeField] GameObject SubmitBtn, ShowAnswerBtn, GoToARBtn;
    [SerializeField] GameObject[] AnswerPool;

    public void backClick()
    {
        if (MainPage.activeSelf)
        {
            SceneManager.LoadSceneAsync("Menu", LoadSceneMode.Single);
        }
        else
        {
            foreach (GameObject k in AnswerPool)
            {
                if (k.activeInHierarchy)
                {
                    k.GetComponent<InputAnswer>().Clear();
                    k.GetComponent<InputAnswer>().Input.enabled = true;
                }
            }
            TrianglePage.SetActive(false);
            CirclePage.SetActive(false);
            RectanglePage.SetActive(false);

            SubmitBtn.SetActive(false);
            ShowAnswerBtn.SetActive(false);
            GoToARBtn.SetActive(false);

            MainPage.SetActive(true);
        }
    }
    public void TriangleClick()
    {
        MainPage.SetActive(false);
        TrianglePage.SetActive(true);
        SubmitBtn.SetActive(true);
    }
    public void CircleClick()
    {
        MainPage.SetActive(false);
        CirclePage.SetActive(true);
        SubmitBtn.SetActive(true);
    }
    public void RectangleClick()
    {
        MainPage.SetActive(false);
        RectanglePage.SetActive(true);
        SubmitBtn.SetActive(true);
    }

    public void SubmitClick()
    {
        foreach (GameObject k in AnswerPool)
        {
            if (k.activeInHierarchy)
            {
                k.GetComponent<InputAnswer>().Submit();
            }
        }
        SubmitBtn.SetActive(false);
        ShowAnswerBtn.SetActive(true);
        GoToARBtn.SetActive(true);
    }

    public void ShowAnswerClick()
    {
        foreach (GameObject k in AnswerPool)
        {
            if (k.activeInHierarchy)
            {
                k.GetComponent<InputAnswer>().ShowAnswer();
            }
        }
    }

    public void GoToARClick()
    {
        if (TrianglePage.activeSelf)
        {
            SceneManager.LoadSceneAsync("AR_Triangle", LoadSceneMode.Single);
        }
        else if (CirclePage.activeSelf)
        {
            SceneManager.LoadSceneAsync("AR_Cirlce", LoadSceneMode.Single);
        }
        else
        {
            SceneManager.LoadSceneAsync("AR_Rectangle", LoadSceneMode.Single);
        }
    }
}
