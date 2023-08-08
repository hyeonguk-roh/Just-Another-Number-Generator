using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using TMPro;

public class NumberGen : MonoBehaviour
{
    private int min = 0;
    private int max = 0;

    public TMP_Text numberText;
    public TMP_InputField number1;
    public TMP_InputField number2;

    public void GenerateRandom()
    {
        if(!int.TryParse(number1.text, out min)) {
            min = 0;
        }
        if(!int.TryParse(number2.text, out max)) {
            max = 0;
        }
        numberText.text = Random.Range(min, max).ToString();
        Debug.Log("Generated " + numberText.text);
    }
}
