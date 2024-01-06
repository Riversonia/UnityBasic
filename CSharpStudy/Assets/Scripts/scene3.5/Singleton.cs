using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    单例模式 singleton    
    1 实例化全局唯一
        static 属于全局，但是不属于类对象的本身
    2 实例只可以在类的内部发生
        需要将构造函数私有化，外部无法通过new访问
    3 提供一个供外部访问的变量

 */
public class MySingleton
{
    private MySingleton()
    {
        Debug.Log("\n MySingleton constructed!");
    }


    private static MySingleton _instance;
    public static MySingleton Instance
    {
        get
        {
            if (_instance == null)
                _instance = new MySingleton();
            return _instance;

        }

    }
   
    public void Show()
    {
        Debug.Log("Show");
    }
}
public class Singleton : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        MySingleton single1 = MySingleton.Instance;
        single1.Show();
        MySingleton single2 = MySingleton.Instance;
        single2.Show();

        MySingleton single3 = MySingleton.Instance;
        single3.Show();

        //MySingleton single1 = new MySingleton();        
        //MySingleton single2 = new MySingleton();        
        //MySingleton single3 = new MySingleton();

        Debug.Log("\nsingle1 = " + single1.GetHashCode() + "\nsingle2 = " + single2.GetHashCode() + "\nsingle3 = " + single3.GetHashCode());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
