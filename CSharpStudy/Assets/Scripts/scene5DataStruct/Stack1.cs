using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Stack1 : MonoBehaviour
{
    Stack st1 = new Stack();

    // Start is called before the first frame update
    void Start()
    {
        st1.Push("a");
        st1.Push("b");
        st1.Push("c");
        st1.Push("d");

        Debug.Log(st1.Count);

        string v = (string)st1.Pop();

        Debug.Log(v);
        Debug.Log(st1.Count);

        string x = (string)st1.Peek(); // 获取栈顶元素值，但不需要出栈pop操作
        Debug.Log(x);
        Debug.Log(st1.Count);

        // 遍历
        foreach (var v1 in st1)
            Debug.Log(v1);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
