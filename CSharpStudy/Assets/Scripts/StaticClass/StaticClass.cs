using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

/*
    1 const
        1) ����������const���������ⲿ����ʱ������ͨ���������з��ʣ����������޸�ֵ
        2�� ֻ������������ʱ��ʼ�������������κ������ط������ʼ�����������캯��
        3�� ĳ�̶ֳ��ϱ�const���εı�����ֵ���ɸı䣬��Ϊ����
    2 readonly
        1) readonly ������� const ��ͬ����ͬһ�����ͣ��Զ����������ͣ�ϵͳ�涨�Ļ����������ͣ�
        2) readonly ���ε��������ͣ� ���Ա����ʵ�����з��ʣ����ǲ����Զ�ֵ�����޸�
        3) readonly �ĳ�ʼ����ֻ���ڹ��캯�����ߵ������С�
    3 �����������η��Ŀ���
        1����ͨ���������η����ɵ��﷨�죬��ʵ�������ⲿֻ����Ч�� get set ѧϰvalue�Ĵ��븳ֵ����
    4 ��̬���캯�� static func()
        1����̬���캯����Ҫ�ӷ������η�����Ϊϵͳ���Զ�����
        2) ��̬���캯�������۶���ʵ�� ����ֻ��ϵͳ�Զ�����һ��
    5 ��̬�� static
        1) ��̬�� ��������ʵ�����캯������ʱ����̬��Ĺ��캯����������û�����У�
        2) ��̬�� ������ʵ����
        3) ��̬����ڲ���Ա����ʱ ��̬��Աstatic���߳���const
        4) ��̬���޷���Ϊ�����������޷���Ϊ���౻����̳У�

    6 ������ abstruct
        1) �����಻����ʵ����
        2��֧�ֹ��캯��
        3�� ��������Լ̳г�����
        4����̬���캯��ִֻ��һ�Σ����������Ĺ��캯������ݲ�ͬ��ʵ�����ж��
        5�������������麯��virtual
        6���������к�������Ϊabstruct�������в�������������壬���������б��븲��override
    7 �ܷ��� sealed
       *1) �ܷ��಻�����������������̳У�
        2) �ܷ���sealed �ͳ�����abstruct ���ܹ���
        3���ܷ����ڵĺ���������������sealed�ؼ���
        4���ܷ�����Լ̳г����ࣨ��ͨ�ࡢ�����ࣩ�ͽӿ�Interface
 */
public class MyClass
{
    public const int mValue = 4;
    public readonly int mValue2 = 2;
    public MyClass()
    {
        mValue2 = 4;
    }

    public void Show()
    {
       // mValue2 = 4;
    }
    public int mValue3
    {
        get;
        private set;
    }

    private int m_Value4;
    public int mValue4
    {
        get { return m_Value4; }
        set { m_Value4 = value; }
    }
}

public abstract class MyAbstractClass
{
    public MyAbstractClass()
    {

    }

    static MyAbstractClass()
    {

    }
}



public class StaticClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //func();
        Func1();
        
    }
    void func()
    {
        MyClass myClass = new MyClass();
        int temp = myClass.mValue2;
        int b = myClass.mValue4;
        myClass.mValue4 = 1000;
    }
    void Func1()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
