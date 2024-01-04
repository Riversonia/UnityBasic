using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 委托 delegate
        类似于函数的指针
 */

public class BaseDelegate : MonoBehaviour
{
    // 委托声明
    public delegate void ShowDelegate();
    public delegate void ShowDelegate2(int a, int b);
    public delegate int ShowDelegate3(int a);
    public delegate void ShowDelegate4<T>(T a);
    // Start is called before the first frame update
    void Start()
    {
        // 委托实现调用
        ShowDelegate show = Show1;

        show();
        show.Invoke();


        ShowDelegate2 show2 = Show2;
        show2(1, 2);

        ShowDelegate3 show3 = Show3;
        Debug.Log(show3(5));

        ShowDelegate4<string> show4 = Show4;
        show4("abc123");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Show1()
    {
        Debug.Log("Show1");
    }

    private void Show2(int a, int b)
    {
        Debug.Log(a + b);
    }

    private int Show3(int a)
    {
        return a * 3;
    }
    private void Show4(string a)
    {
        Debug.Log(a);
    }
}

