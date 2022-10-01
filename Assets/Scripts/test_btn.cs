using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;
using UnityEngine.UI;

public class test_btn : MonoBehaviour
{

    [SerializeField] GameObject MainPage, TrianglePage, CirclePage, RectanglePage, CylineerPage, ConePage;
    [SerializeField] GameObject SubmitBtn, ShowAnswerBtn, GoToARBtn;
    [SerializeField] GameObject UnderBtn;

    // [SerializeField] GameObject[] AnswerPool;

    [SerializeField] GameObject ActivePage;
    public void backClick()
    {
        if (MainPage.activeSelf)
        {
            SceneManager.LoadSceneAsync("Menu", LoadSceneMode.Single);
        }
        else
        {
            foreach (GameObject k in ActivePage.GetComponent<AnswerPool>().Pool)
            {
                if (k.activeInHierarchy)
                {
                    k.GetComponent<InputAnswer>().Clear();
                }
            }
            TrianglePage.SetActive(false);
            CirclePage.SetActive(false);
            RectanglePage.SetActive(false);
            CylineerPage.SetActive(false);
            ConePage.SetActive(false);

            Go_Back_To_Top();

            SubmitBtn.SetActive(false);
            ShowAnswerBtn.SetActive(false);
            GoToARBtn.SetActive(false);

            UnderBtn.SetActive(false);

            MainPage.SetActive(true);
            ActivePage = null;
        }
    }
    void Go_Back_To_Top()
    {
        TrianglePage.transform.GetComponent<ScrollRect>().verticalNormalizedPosition = 1;
        CirclePage.transform.GetComponent<ScrollRect>().verticalNormalizedPosition = 1;
        RectanglePage.transform.GetComponent<ScrollRect>().verticalNormalizedPosition = 1;
        CylineerPage.transform.GetComponent<ScrollRect>().verticalNormalizedPosition = 1;
        ConePage.transform.GetComponent<ScrollRect>().verticalNormalizedPosition = 1;
    }

    void Btn_Active_Set()
    {
        MainPage.SetActive(false);
        SubmitBtn.SetActive(true);
        UnderBtn.SetActive(true);
    }
    public void TriangleClick()
    {
        Btn_Active_Set();
        TrianglePage.SetActive(true);
        ActivePage = TrianglePage;
    }
    public void CircleClick()
    {
        Btn_Active_Set();
        CirclePage.SetActive(true);
        ActivePage = CirclePage;
    }
    public void RectangleClick()
    {
        Btn_Active_Set();
        RectanglePage.SetActive(true);
        ActivePage = RectanglePage;
    }

    public void CylineerClick()
    {
        Btn_Active_Set();
        CylineerPage.SetActive(true);
        ActivePage = CylineerPage;
    }

    public void ConeClick()
    {
        Btn_Active_Set();
        ConePage.SetActive(true);
        ActivePage = ConePage;
    }

    public void SubmitClick()
    {
        foreach (GameObject k in ActivePage.GetComponent<AnswerPool>().Pool)
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
        foreach (GameObject k in ActivePage.GetComponent<AnswerPool>().Pool)
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
            SceneManager.LoadSceneAsync("AR_Circle", LoadSceneMode.Single);
        }
        else if (RectanglePage.activeSelf)
        {
            SceneManager.LoadSceneAsync("AR_Rectangle", LoadSceneMode.Single);
        }
        else if (CylineerPage.activeSelf)
        {
            SceneManager.LoadSceneAsync("AR_Cylineer", LoadSceneMode.Single);
        }
        else 
        {
            SceneManager.LoadSceneAsync("AR_Cone", LoadSceneMode.Single);
        }
    }

    public void ScrollChange(Vector2 value)
    {
        if (value.y <= 0.1)
        {
            UnderBtn.SetActive(false);
        }
        else
        {
            UnderBtn.SetActive(true);
        }
    }
}
