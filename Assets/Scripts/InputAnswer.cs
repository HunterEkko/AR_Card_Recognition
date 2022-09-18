using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class InputAnswer : MonoBehaviour
{
    private TMP_InputField Input;
    [SerializeField] private string Answer;
    // Start is called before the first frame update
    void Start()
    {
        Input = this.gameObject.GetComponent<TMP_InputField>();
        Input.characterLimit = 8; 
    }

    public void Submit()
    {
        if(!Input.text.Equals(Answer))
        {
            Input.gameObject.GetComponentInChildren<TextMeshProUGUI>().color = Color.red;
        }
    }

    public void ShowAnswer()
    {
        Input.text = Answer;
        Input.gameObject.GetComponentInChildren<TextMeshProUGUI>().color = Color.green;
    }
}
