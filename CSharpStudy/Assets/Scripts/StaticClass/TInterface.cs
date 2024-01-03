using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*  
 *  1 接口特点
 *  1) 声明函数可以，但是不能包括函数的实现 接口不可以定义字段（即数据成员）
 *  2) 不能将函数的声明改为 private
 *  3) 接口不可以被实例化
 *  4) 接口允许单一继承，也允许多重继承 类也可以继承接口
 *  5) 类只允许继承一个类，但是可以同时继承多个接口
 *  
 *  2 接口与抽象类的区别
 *  1) 接口不允许声明成员变量和构造函数，抽象类可以
 *  2）接口只允许声明函数，但是不允许构造，抽象类可以声明函数并且可以构造函数
 *  3) 访问修饰符
 *      接口      默认是 public  但是不允许变成privite
 *      抽象类    默认是 private 函数前面如果是 abstract      则访问修饰符不允许是 private； 
 *                              但是          非abstract    声明的函数允许private 和protected
 *  4) 接口允许多重继承多个接口，抽象类不允许多重继承多个类
 *  
 *  3 接口和抽象类的相同点
 *  1) 都不允许实例化
 *  2) 都支持只声明函数，不包含函数实现
 *  3) 派生（子类）：派生（继承）他们的类 都必须去实现接口和抽象类的方法
 
 */

public interface IBaseInterface1
{
    void ShowWindow();
    void HideWindow();

    //void Show1()
    //{
    //    Debug.Log("1");

    //}
    // 1 声明函数可以，但是不能包括函数的实现 接口不可以定义字段（即数据成员）
    // private void Show3();
    // 2 不能将函数的声明改为 private
}

public interface IBaseInterface2
{
    void PlaySound();
    void CloseSound();
}

public interface IMyInterface: IBaseInterface1,  IBaseInterface2
{

}

public class MyClass4 : IMyInterface
{
    public void CloseSound()
    {
        throw new System.NotImplementedException();
    }

    public void HideWindow()
    {
        throw new System.NotImplementedException();
    }

    public void PlaySound()
    {
        throw new System.NotImplementedException();
    }

    public void ShowWindow()
    {
        throw new System.NotImplementedException();
    }
}


public class TInterface : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // IBaseInterface1 inter = new IBaseInterface();
        // 3 接口不可以被实例化

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
