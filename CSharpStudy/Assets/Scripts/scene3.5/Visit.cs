using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
/**
 * 观察者模式
 *    需求
 *          野猫来了 老鼠A B C惊吓逃走
 *          
 *          
 */

/*
   多态    

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
    public Action actions; // publisher（发布者） 
    public Cat(string name) : base(name) 
    {
        
    }
    public void Coming( )
    {
        Debug.Log( strName + " coming");
        if (actions != null)
            actions();  // 通过多播模式完成观察者模式 一对多

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
        cat.actions += this.Run;    // subscriber (订阅者)
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
