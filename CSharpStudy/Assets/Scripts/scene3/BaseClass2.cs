using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;

/*
    封装： 
        把一个或者多个项目封闭在一个物理的或者逻辑的包（package）中，防止对实现细节的访问
        将实现细节通过接口的方式提供给第三方，而不需要其关心细节

    virtual / override

    抽象和封装时相辅相成的，抽象允许相关信息可视化，而封装则使开发者实现所需级别的抽象，设置访问修饰符来改变访问权限

    访问修饰符： private protected

    继承
    C#不支持多重继承类，但是可以多重继承接口
    C++ 可以

    覆盖 ： 发生在继承关系中 通过virtual和override来实现； 函数名以及函数参数是一样的
    重载 ： 发生在任何的关系中，函数名称相同，但是函数参数不一样(有参数和无参数，参数顺序不一致，参数个数不一致都可以)，就会出现函数重载
 
    this 和 base 的区别
    this 是访问当前类的成员
    base 是访问基类中的成员
 */ 
public class Polygon    // 基类（父类）
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
   
    public virtual void CalcArea()  // virtual代表虚函数，子类在继承时可以覆盖父类同名函数，若子类没有覆写，则会执行父类的同名函数
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

class Rectangle: Polygon   // 派生类（子类）
{
    public Rectangle()
    {

       
    }

    ~Rectangle()
    {

    }
    public override void CalcArea() //覆盖父类中的CalcArea函数 virtual
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

        // 运行时多态 运行时无法确定调用哪一个方法，只有在运行时才确定的方法
        // 只允许子类给父类赋值，不允许父类给子类赋值
        // 父类 = 子类
        // 基类 = 派生类
        Polygon baseParent1 = recShape;
        baseParent1.Show();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
