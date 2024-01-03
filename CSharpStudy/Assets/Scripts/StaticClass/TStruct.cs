using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

/*
    struct 与 class 的异同

     相同点：
        1）静态构造函数 都支持
        2）都支持自定义函数
        3）const的使用方式都一样，声明时就需要直接赋值 
        
     不同点：
        1） 构造函数
            结构体 不允许定义无参构造函数，只允许构造有参函数
            类     都可以定义
        2） 析构函数
            结构体 不允许定义
            类     可以定义
        3） 函数修饰符
            结构体 不允许修饰为为 virtual ，protected
            类     可以修饰
        4） 类型修饰符
            结构体 不允许声明为abstruct
            类     可以定义
        5） 关于变量（字段）
            i.普通变量  
            结构体 结构体声明的全局普通变量（不带有修饰符的），不能在声明中直接赋值，只能在构造函数里赋值
            类     可以直接赋值
            ii. readonly
            结构体 声明的radonly变量只能在构造函数中声明
            类     构造函数和声明时都可以直接赋值
        6)  继承
            结构体 结构体不可以互相继承，但是可以继承接口
            类     类与类之间可以互相继承，除了sealed密封类除外
        7） 使用
            i. 访问变量
            结构体 访问成员变量，给变量赋值就可以直接访问，如果不通过new初始化，不可以直接访问其 内部变量（const除外）
            类     必须实例化对象才可以访问
            ii. 访问函数
           *结构体变量和类的对象必须经过初始化才可以访问函数
         8）new
            结构体 结构体的new不会在堆上分配内存，仅仅是调用结构体的构造函数初始化函数
            类     类的new会在对上分配内存，而且也会调用类的构造函数初始化
 
    

 
 */          

struct MyStruct
{

}

class MyClass5
{

}
public class TStruct : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
