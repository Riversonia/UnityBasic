using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
/**
 * �۲���ģʽ
 *    ����
 *          Ұè���� ����A B C��������
 *          
 *          
 */

/*
   ��̬    

 */
public class Animal
{
    protected string strName;

    public Animal(string name)
    {
        this.strName = name;
    }

    public virtual void Run()
    {

    }
}

public class Cat: Animal
{
    public Action actions; // publisher�������ߣ� 
    public Cat(string name) : base(name) 
    {
        
    }
    public void Coming( )
    {
        Debug.Log( strName + " coming");
        if (actions != null)
            actions();  // ͨ���ಥģʽ��ɹ۲���ģʽ һ�Զ�

        this.Run();
    }

    public override void Run()
    {
        Debug.Log("Cat catch Mouse");

    }
}

public class Mouse: Animal
{
    public Mouse(string name, Cat cat) : base(name) 
    {
        cat.actions += this.Run;    // subscriber (������)
    }
    public override void Run()
    {
        Debug.Log(strName + " run");
    }
}

public class Visit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cat cat = new Cat("Tom");

        Animal mouseA = new Mouse("Jerry1", cat);
        Animal mouseB = new Mouse("Jerry2", cat);
        Animal mouseC = new Mouse("Jerry3", cat);
        Animal mouseD = new Mouse("Jerry4", cat);

        cat.Coming();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
