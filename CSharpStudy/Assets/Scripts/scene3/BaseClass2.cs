using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;

/*
    ��װ�� 
        ��һ�����߶����Ŀ�����һ������Ļ����߼��İ���package���У���ֹ��ʵ��ϸ�ڵķ���
        ��ʵ��ϸ��ͨ���ӿڵķ�ʽ�ṩ����������������Ҫ�����ϸ��

    virtual / override

    ����ͷ�װʱ�ศ��ɵģ��������������Ϣ���ӻ�������װ��ʹ������ʵ�����輶��ĳ������÷������η����ı����Ȩ��

    �������η��� private protected

    �̳�
    C#��֧�ֶ��ؼ̳��࣬���ǿ��Զ��ؼ̳нӿ�
    C++ ����

    ���� �� �����ڼ̳й�ϵ�� ͨ��virtual��override��ʵ�֣� �������Լ�����������һ����
    ���� �� �������κεĹ�ϵ�У�����������ͬ�����Ǻ���������һ��(�в������޲���������˳��һ�£�����������һ�¶�����)���ͻ���ֺ�������
 
    this �� base ������
    this �Ƿ��ʵ�ǰ��ĳ�Ա
    base �Ƿ��ʻ����еĳ�Ա
 */ 
public class Polygon    // ���ࣨ���ࣩ
{
    public int Length;
    public int Width;
    public string Color;
    public string Name;

    public float Area;
    public void ShowBaseInfo()
    {
        Debug.Log(" \n" + Color +" "+ Name + " " + Length + " " + Width);
    }
   
    public virtual void CalcArea()  // virtual�����麯���������ڼ̳�ʱ���Ը��Ǹ���ͬ��������������û�и�д�����ִ�и����ͬ������
    {

    }

    public virtual void Show()
    {
        Debug.Log("\n Polygon Show ");
    }

    public void ShowFunc()
    {

    }

    public void ShowFunc(int a)
    {

    }
}

class Rectangle: Polygon   // �����ࣨ���ࣩ
{
    public Rectangle()
    {

       
    }

    ~Rectangle()
    {

    }
    public override void CalcArea() //���Ǹ����е�CalcArea���� virtual
    {
        Area = Length * Width;    
    }

    public override void Show()
    {
        Debug.Log("\n Rectangle Show ");
    }

    public void ShowFunc(int a , string b, int c)
    {

    }
}

class Triangle: Polygon
{
    public Triangle()
    {

    }
    ~Triangle()
    {

    }
    public override void CalcArea()
    {
        Area = Length * Width / 2;
    }
    public override void Show()
    {
        Debug.Log("\n Triangle Show ");
    }
}

public class BaseClass2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rectangle recShape = new Rectangle();
        recShape.Length = 8;
        recShape.Width = 4;
        recShape.Color = "red";
        recShape.Name = "rec1";
        recShape.ShowBaseInfo();
        recShape.CalcArea();
        recShape.ShowFunc();
        Debug.Log("\n" + recShape.Name + " area is " + recShape.Area);

        // ����ʱ��̬ ����ʱ�޷�ȷ��������һ��������ֻ��������ʱ��ȷ���ķ���
        // ֻ������������ำֵ��������������ำֵ
        // ���� = ����
        // ���� = ������
        Polygon baseParent1 = recShape;
        baseParent1.Show();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
