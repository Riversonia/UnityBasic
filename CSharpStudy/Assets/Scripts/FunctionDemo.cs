using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class FunctionDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 1;
        float b = 1.2f;
        Func(a, b);
        int c = 2;
        Debug.Log("\n c��ֵΪ: " + c);
        c = Double(c);
        Debug.Log("\n c��ֵΪ: " + c);
    }

    void Func(int arg1, float arg2)
    {
        Debug.Log("\n Func������");
    }

    int Double(int arg)
    {
        Debug.Log("\n Double������");
        return arg * 2;
    }
}
