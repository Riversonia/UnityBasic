using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

/*
    1 const
        1) 类内声明的const变量，在外部访问时，必须通过类名进行访问，但不可以修改值
        2） 只能在类内声明时初始化，不允许在任何其他地方对其初始化，包括构造函数
        3） 某种程度上被const修饰的变量的值不可改变，即为常量
    2 readonly
        1) readonly 不允许和 const 共同修饰同一个类型（自定义数据类型，系统规定的基本数据类型）
        2) readonly 修饰的数据类型， 可以被类的实例进行访问，但是不可以对值进行修改
        3) readonly 的初始化。只能在构造函数或者的声明中。
    3 变量访问修饰符的控制
        1）可通过访问修饰符构成的语法快，来实现类似外部只读的效果 get set 学习value的代码赋值流程
    4 静态构造函数 static func()
        1）静态构造函数不要加访问修饰符，因为系统会自动调用
        2) 静态构造函数，无论多少实例 都会只被系统自动调用一次
    5 静态类 static
        1) 静态类 不允许有实例构造函数（暂时：静态类的构造函数经过测试没有运行）
        2) 静态类 不允许被实例化
        3) 静态类的内部成员必须时 静态成员static或者常量const
        4) 静态类无法作为基类派生（无法作为父类被子类继承）

    6 抽象类 abstruct
        1) 抽象类不允许被实例化
        2）支持构造函数
        3） 抽象类可以继承抽象类
        4）静态构造函数只执行一次；但是其他的构造函数会根据不同的实例进行多次
        5）抽象类允许虚函数virtual
        6）若父类中函数声明为abstruct，则父类中不允许包含函数体，则在子类中必须覆盖override
    7 密封类 sealed
       *1) 密封类不允许被派生（不允许被继承）
        2) 密封类sealed 和抽象类abstruct 不能共存
        3）密封类内的函数。不允许增加sealed关键字
        4）密封类可以继承常见类（普通类、抽象类）和接口Interface
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
