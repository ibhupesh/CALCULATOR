using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public InputField number1;
    public InputField number2;
    public Text result;
    void Start()
    {
        result.text = "0";
    }
    public void Add()
    {
        int a = int.Parse(number1.text);
        int b = int.Parse(number2.text);
        result.text = (a + b).ToString();
    }
    public void Subtract()
    {
        int a = int.Parse(number1.text);
        int b = int.Parse(number2.text);
        result.text = (a - b).ToString();
    }
    public void Mul()
    {
        int a = int.Parse(number1.text);
        int b = int.Parse(number2.text);
        result.text = (a * b).ToString();
    }
    public void Div()
    {
        int a = int.Parse(number1.text);
        int b = int.Parse(number2.text);
        result.text = (a / b).ToString();
    }


}
