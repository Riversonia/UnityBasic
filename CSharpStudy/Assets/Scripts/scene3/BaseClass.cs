using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 �������η� �Ƿ��ܹ������ʣ��ң���
public  �κι��г�Ա�����Ա��ⲿ�������
private ֻ��ͬһ�����еĺ������Է�������˽�г�Ա
protected   ������ڲ��ͼ̳����п��Է���
internal    ͬһ�����򼯵Ķ�����Է���
protected internal  protected U internal

private < internal/protected < protected internal < public

 */

namespace MySpace
{
    // �����ռ䣬�ڸÿռ��ڵ�������Ʋ������ظ�
    public class MyClass
    {
        // ���캯�� ������newʵ��ʱ�ᱻ�Զ�ִ��
        // �������� �����ڵ�ǰ���������ʱ���ᱻ�Զ�ִ��

        /* 
         * ������ 
         * �����������ı�����������Ķ�����ִ���걾����ʱ�ᱻ�Զ�����
         * ���������������ĳ�Ա������������Ķ���ֻ�е�ǰ�౻����ʱ�����������������������������Żᱻ����
        */
        public MyClass()    // ��д��Ĺ��캯��ϵͳ���Զ������������д���ִ�б�д�Ĺ��캯��
        {
            // �޲ι���
            Debug.Log("\n MyClass constructed, default value = " + a);
        }
        public MyClass (int value)
        {
            // �вι���
            a = value;
            Debug.Log("\n MyClass constructed, value = " + a);
        }

        ~MyClass()  // ���������������д�вι���
        {         
            Debug.Log("\n public class MyClass distruction function running ");
        }

        // static class��������static����ֻ��ͨ��class������ȥ���ʣ�������ͨ��class��ʵ����ȥ����
        public static int a = 5; // private ���ʼ�������
        public void Func1()
        {
            Debug.Log("\n MyClass.Func1() called");
        }
    }
}


public class BaseClass : MonoBehaviour
{
    MySpace.MyClass myClass;

    // Start is called before the first frame update
    void Start()
    {
        myClass = new MySpace.MyClass();
        myClass = new MySpace.MyClass(10);
       
        Debug.Log("\n" + MySpace.MyClass.a);   // static ͨ��������ַ��� MyClass.a

        myClass.Func1();        // static ͨ�����ʵ�������� myClass.Func1()
        
    }

    // Update is called once per frame
    void Update()
    {
        // Input ����������������
        if (Input.GetMouseButton(0)) // 0 mouse left, 1 mouse right, 2 roll
        {
            Destroy( this.gameObject );
        }
        
    }
}
