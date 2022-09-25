using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;
using UnityEngine.UI;

public class test_btn : MonoBehaviour
{

    [SerializeField] GameObject MainPage, TrianglePage, CirclePage, RectanglePage;
    [SerializeField] GameObject SubmitBtn, ShowAnswerBtn, GoToARBtn;
    [SerializeField] GameObject UnderBtn; 
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

            Go_Back_To_Top();

            SubmitBtn.SetActive(false);
            ShowAnswerBtn.SetActive(false);
            GoToARBtn.SetActive(false);

            UnderBtn.SetActive(false);

            MainPage.SetActive(true);
        }
    }
    void Go_Back_To_Top()
    {
        TrianglePage.transform.GetComponent<ScrollRect>().verticalNormalizedPosition = 1;
        CirclePage.transform.GetComponent<ScrollRect>().verticalNormalizedPosition = 1;
        RectanglePage.transform.GetComponent<ScrollRect>().verticalNormalizedPosition = 1;
    }
    public void TriangleClick()
    {
        MainPage.SetActive(false);
        TrianglePage.SetActive(true);
        SubmitBtn.SetActive(true);
        UnderBtn.SetActive(true);
    }
    public void CircleClick()
    {
        MainPage.SetActive(false);
        CirclePage.SetActive(true);
        SubmitBtn.SetActive(true);
        UnderBtn.SetActive(true);
    }
    public void RectangleClick()
    {
        MainPage.SetActive(false);
        RectanglePage.SetActive(true);
        SubmitBtn.SetActive(true);
        UnderBtn.SetActive(true);
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
