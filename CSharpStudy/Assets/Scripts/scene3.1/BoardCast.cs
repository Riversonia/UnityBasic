using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/*
1. 匿名函数 没有名字的方法称呼为匿名方法

2. 多播委托
    += -=
    委托类型属于引用类型，引用类型的默认值是NULL，直接输用会报错空异常；
    因此在使用之前一般会判断引用对象是否为空

3、event事件
    1) event事件 只允许作为类的成员变量使用，且尽可以在类内调用，不可以被外部直接调用
    2) 当作为某类成员 event事件在外部类赋值时，只能通过 +=或者-= 的方法来赋值
       对于普通的Action 则可以通过 = += -= 都可以赋值

 */

public class MyEventClass
{
    public event Action eventAction;
    public Action defaultAction;

    public void Send()
    {
        if (eventAction != null)
            eventAction();
    }
}


public class BoardCast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //1
        //Action action = delegate ()
        //{
        //    Debug.Log("\n匿名函数");
        //};

        //action();

        //2
        // action上注册show1和show2
        //Action action = Show1;
        //action += Show2;

        //// action上注销Show1
        //action -= Show1;
        //// action -= Show2;

        //if (action != null) // 判断action 是否为空，不为空则会运行
        //{
        //    action();
        //}

        //3
        MyEventClass myClass = new MyEventClass();
        myClass.eventAction += Show1;
        myClass.defaultAction = Show2;

        myClass.defaultAction();
        myClass.Send();



      
    }

    private void Show1()
    {
        Debug.Log("\n Show1");
    }

        private void Show2()
    {
        Debug.Log("\n Show2");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
