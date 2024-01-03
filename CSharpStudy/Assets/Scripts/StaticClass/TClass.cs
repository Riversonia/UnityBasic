using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Lumin;

/*
    类中定义一个数组，此类具备设置数据和访问数据的能力
    泛型 public class MyClass<T> { ... } T 为类型（类型可以是系统自定义的，也可以是自定义类）
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
 * 1 泛型约束要求
    .NET 含有以下5种泛型约束 
    where T: class      类
    where T: struct     结构体类型
    where T: new()      无参构造函数
    where T: NameOfBaseClass    继承名为NameOfBaseClass的类
    where T: NameOfInterface    实现名为NameOfInterface的接口    

    2 泛型方法
    在函数后面加泛型就可
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

        // 不加 where 时，访问 MyClass 的实例中 MyClassType 下的 (int)a 时，需要通过类的实例化 myClass.Get(index).a 来访问

        Debug.LogFormat("\n第{0}号位置，值为{1}", 0, myClass.Get(0)); 
        Debug.LogFormat("\n第{0}号位置，值为{1}", 1, myClass.Get(1));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
