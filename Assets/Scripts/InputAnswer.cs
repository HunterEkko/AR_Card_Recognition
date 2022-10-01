using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class InputAnswer : MonoBehaviour
{
    public bool IsButtonInput;
    [SerializeField] string BtnPos;
    public GameObject[] Btn; // 是，不是
    public TMP_InputField Input;
    [SerializeField] private string Answer;
    [SerializeField] private int MaxLen;
    public Color colorRight, colorWrong, Btn_Select_Color;
    // Start is called before the first frame update
    void Start()
    {
        Input = this.gameObject.GetComponent<TMP_InputField>();
        Input.characterLimit = MaxLen;
        if (IsButtonInput)
        {
            BtnPos = Btn[0].gameObject.name;
            Input.text = Btn[0].GetComponentInChildren<TextMeshProUGUI>().text;
            Input.enabled = false;
            this.transform.Find("Text Area").GetComponentInChildren<TextMeshProUGUI>().enabled = false;
            Btn_Select_Color = this.transform.Find(BtnPos).GetComponent<Btn_Send_Answer>().Select_Color;
        }
    }

    public void Submit()
    {
        if (IsButtonInput)
        {
            foreach (GameObject b in Btn)
            {
                b.GetComponent<Button>().enabled = false;
                ColorBlock theColor;
                theColor = b.GetComponent<Button>().colors;
                theColor.normalColor = Color.white;
                b.GetComponent<Button>().colors = theColor;
            }
        }
        if (!Input.text.Equals(Answer))
        {
            if (IsButtonInput)
            {
                this.transform.Find(BtnPos).GetComponent<Image>().color = colorWrong;
            }
            else
            {
                Input.gameObject.GetComponentInChildren<TextMeshProUGUI>().color = colorWrong;
            }
        }
        else
        {
            if (IsButtonInput)
            {
                this.transform.Find(BtnPos).GetComponent<Image>().color = Btn_Select_Color;
            }
        }
        Input.enabled = false;
    }

    public void SetLegel(int num)
    {
        if (num == 1)
        {
            Answer = "可以";
        }
        else if (num == 2)
        {
            Answer = "不可以";
        }
        else
        {
            Answer = num.ToString();
        }
    }

    public void SetStringValue(string val, string pos)
    {
        Input.text = val;
        BtnPos = pos;
    }

    public void ShowAnswer()
    {
        if (!Input.text.Equals(Answer))
        {
            if (IsButtonInput)
            {
                foreach (GameObject b in Btn)
                {
                    if (b.GetComponentInChildren<TextMeshProUGUI>().text.Equals(Answer))
                    {
                        b.GetComponent<Image>().color = colorRight;
                    }
                    else
                    {
                        b.GetComponent<Image>().color = Color.white;
                    }
                }
            }
            else
            {
                Input.text = Answer;
                Input.gameObject.GetComponentInChildren<TextMeshProUGUI>().color = colorRight;
            }
        }
    }

    public void Clear()
    {
        if (IsButtonInput)
        {
            foreach (GameObject b in Btn)
            {
                b.GetComponent<Image>().color = Color.white;
                b.GetComponent<Button>().enabled = true;
            }
            Input.text = Btn[0].GetComponentInChildren<TextMeshProUGUI>().text;
        }
        else
        {
            Input.enabled = true;
            Input.text = "";
            Input.gameObject.GetComponentInChildren<TextMeshProUGUI>().color = Color.black;
        }
    }
}
