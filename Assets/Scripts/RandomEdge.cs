using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class RandomEdge : MonoBehaviour
{
    private int[] num = new int[3];
    public GameObject blank;
    private TMP_Text tmp;
    void Start()
    {
        tmp = this.GetComponent<TMP_Text>();
        randomEdge();
    }
    private void randomEdge()
    {
        num[0] = Random.Range(0, 20);
        num[1] = Random.Range(0, 20);
        num[2] = Random.Range(0, 20);
        if (num[0] + num[1] > num[2] && num[1] + num[2] > num[0] && num[0] + num[2] > num[1])
        {
            blank.GetComponent<InputAnswer>().SetLegel(1);
        }
        else
        {
            blank.GetComponent<InputAnswer>().SetLegel(2);
        }
        tmp.text = num[0] + " 公分，" + num[1] + " 公分，" + num[2] + " 公分";
    }
}
