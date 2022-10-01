using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Btn_Send_Answer : MonoBehaviour
{
    [SerializeField] string Value;
    public Color Select_Color;
    private void Start()
    {
        Value = this.GetComponentInChildren<TextMeshProUGUI>().text;
    }
    public void Send_Answer()
    {
        this.transform.parent.gameObject.GetComponent<InputAnswer>().SetStringValue(Value, this.gameObject.name);
        Set_Select_Color();
    }

    private void Set_Select_Color()
    {
        foreach(GameObject Btn in this.transform.parent.GetComponent<InputAnswer>().Btn)
        {
            ColorBlock theColor;
            theColor = Btn.GetComponent<Button>().colors;
            if(Btn.name.Equals(this.gameObject.name))
            {
                // theColor.normalColor = new Color((float)0.1933962, (float)0.7781254, 1, 1);
                theColor.normalColor = Select_Color;
            }else
            {
                theColor.normalColor = Color.white;
            }
            Btn.GetComponent<Button>().colors = theColor;
        }
    }
}
