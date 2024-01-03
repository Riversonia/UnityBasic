using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Lumin;

/*
    ���ж���һ�����飬����߱��������ݺͷ������ݵ�����
    ���� public class MyClass<T> { ... } T Ϊ���ͣ����Ϳ�����ϵͳ�Զ���ģ�Ҳ�������Զ����ࣩ
 */
public class MyClassType
{
    public int a;

    public MyClassType(int value)
    {
        this.a = value;
    }
}
/*
 * 1 ����Լ��Ҫ��
    .NET ��������5�ַ���Լ�� 
    where T: class      ��
    where T: struct     �ṹ������
    where T: new()      �޲ι��캯��
    where T: NameOfBaseClass    �̳���ΪNameOfBaseClass����
    where T: NameOfInterface    ʵ����ΪNameOfInterface�Ľӿ�    

    2 ���ͷ���
    �ں�������ӷ��;Ϳ�
    public class MyClass
    {
        public void Show<X>(X a)
        {
            Debug.Log("\na = " + a);
        }
    }
 */
public class MyClass15 <T> where T: MyClassType
{

    private T[] m_array;

    public MyClass15(int size)
    {
        m_array = new T[size];
    }

    public void Set(int index, T value)
    {
        m_array[index] = value;
    }

    public int Get(int index)
    {
        return m_array[index].a;
    }
}


public class TClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MyClass15<MyClassType> myClass = new MyClass15<MyClassType>(5);
        myClass.Set(0, new MyClassType(1));
        myClass.Set(1, new MyClassType(2));

        // ���� where ʱ������ MyClass ��ʵ���� MyClassType �µ� (int)a ʱ����Ҫͨ�����ʵ���� myClass.Get(index).a ������

        Debug.LogFormat("\n��{0}��λ�ã�ֵΪ{1}", 0, myClass.Get(0)); 
        Debug.LogFormat("\n��{0}��λ�ã�ֵΪ{1}", 1, myClass.Get(1));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
