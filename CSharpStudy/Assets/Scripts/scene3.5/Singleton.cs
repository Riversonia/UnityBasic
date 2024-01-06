using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    ����ģʽ singleton    
    1 ʵ����ȫ��Ψһ
        static ����ȫ�֣����ǲ����������ı���
    2 ʵ��ֻ����������ڲ�����
        ��Ҫ�����캯��˽�л����ⲿ�޷�ͨ��new����
    3 �ṩһ�����ⲿ���ʵı���

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
