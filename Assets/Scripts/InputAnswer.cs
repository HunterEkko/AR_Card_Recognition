using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class InputAnswer : MonoBehaviour
{
    public TMP_InputField Input;
    [SerializeField] private string Answer;
    public Color colorRight, colorWrong;
    // Start is called before the first frame update
    void Start()
    {
        Input = this.gameObject.GetComponent<TMP_InputField>();
        Input.characterLimit = 5;
    }

    public void Submit()
    {
        if (!Input.text.Equals(Answer))
        {
            Input.gameObject.GetComponentInChildren<TextMeshProUGUI>().color = colorWrong;
        }
        Input.enabled = false;
    }

    public void ShowAnswer()
    {
        if (!Input.text.Equals(Answer))
        {
            Input.text = Answer;
            Input.gameObject.GetComponentInChildren<TextMeshProUGUI>().color = colorRight;
        }
    }

    public void Clear()
    {
        Input.text = "";
        Input.gameObject.GetComponentInChildren<TextMeshProUGUI>().color = Color.black;
    }
}
