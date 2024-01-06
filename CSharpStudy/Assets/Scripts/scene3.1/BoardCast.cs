using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/*
1. �������� û�����ֵķ����ƺ�Ϊ��������

2. �ಥί��
    += -=
    ί�����������������ͣ��������͵�Ĭ��ֵ��NULL��ֱ�����ûᱨ����쳣��
    �����ʹ��֮ǰһ����ж����ö����Ƿ�Ϊ��

3��event�¼�
    1) event�¼� ֻ������Ϊ��ĳ�Ա����ʹ�ã��Ҿ����������ڵ��ã������Ա��ⲿֱ�ӵ���
    2) ����Ϊĳ���Ա event�¼����ⲿ�ำֵʱ��ֻ��ͨ�� +=����-= �ķ�������ֵ
       ������ͨ��Action �����ͨ�� = += -= �����Ը�ֵ

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
        //    Debug.Log("\n��������");
        //};

        //action();

        //2
        // action��ע��show1��show2
        //Action action = Show1;
        //action += Show2;

        //// action��ע��Show1
        //action -= Show1;
        //// action -= Show2;

        //if (action != null) // �ж�action �Ƿ�Ϊ�գ���Ϊ���������
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
