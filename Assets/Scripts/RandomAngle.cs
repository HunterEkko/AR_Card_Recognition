using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class RandomAngle : MonoBehaviour
{
    public GameObject blank;
    private TMP_Text tmp;
    private int[] arr = { 2, 3, 4, 5, 6, 8, 12};
    private int denominator, numerator, ans;
    void Start()
    {
        tmp = this.GetComponent<TMP_Text>();
        generateAngle();
    }
    void generateAngle()
    {
        denominator = arr[Random.Range(0, arr.Length)];
        numerator = Random.Range(1, denominator);
        int k = gcd(denominator, numerator);
        denominator /= k;
        numerator /= k;
        ans = 360 * numerator / denominator;

        tmp.text = denominator.ToString();
        this.transform.parent.Find("Text-numerator").GetComponent<TMP_Text>().text = numerator.ToString();
        blank.GetComponent<InputAnswer>().SetLegel(ans);
    }
    int gcd(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }
        else
        {
            return gcd(b, a % b);
        }
    }
}
