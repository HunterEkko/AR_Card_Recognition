using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test_btn : MonoBehaviour
{
    public void backClick()
    {
        SceneManager.LoadSceneAsync("Menu", LoadSceneMode.Single);
    }
}
