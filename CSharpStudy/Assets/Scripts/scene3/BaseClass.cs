using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 访问修饰符 是否能够被访问（找）到
public  任何共有成员都可以被外部的类访问
private 只有同一个类中的函数可以访问他的私有成员
protected   该类的内部和继承类中可以访问
internal    同一个程序集的对象可以访问
protected internal  protected U internal

private < internal/protected < protected internal < public

 */

namespace MySpace
{
    // 命名空间，在该空间内的类的名称不允许重复
    public class MyClass
    {
        // 构造函数 发生在new实例时会被自动执行
        // 析构函数 发生在当前类对象被销毁时，会被自动执行

        /* 
         * 作用域 
         * 函数内声明的变量，包括类的对象，在执行完本函数时会被自动销毁
         * 但是在类内声明的成员变量，包括类的对象，只有当前类被销毁时，该类管理的其他变量，包括类对象才会被销毁
        */
        public MyClass()    // 不写类的构造函数系统会自动创建，如果编写则会执行编写的构造函数
        {
            // 无参构造
            Debug.Log("\n MyClass constructed, default value = " + a);
        }
        public MyClass (int value)
        {
            // 有参构造
            a = value;
            Debug.Log("\n MyClass constructed, value = " + a);
        }

        ~MyClass()  // 析构函数不允许编写有参构造
        {         
            Debug.Log("\n public class MyClass distruction function running ");
        }

        // static class内声明了static变量只能通过class的名字去访问，不允许通过class的实例化去访问
        public static int a = 5; // private 访问级别区分
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
       
        Debug.Log("\n" + MySpace.MyClass.a);   // static 通过类的名字访问 MyClass.a

        myClass.Func1();        // static 通过类的实例化访问 myClass.Func1()
        
    }

    // Update is called once per frame
    void Update()
    {
        // Input 键盘鼠标监听工具类
        if (Input.GetMouseButton(0)) // 0 mouse left, 1 mouse right, 2 roll
        {
            Destroy( this.gameObject );
        }
        
    }
}
