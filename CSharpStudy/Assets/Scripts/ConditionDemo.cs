using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using JetBrains.Annotations;

/*
    Enum <-> int 
    Enum <-> string
 
 */
public class ConditionDemo : MonoBehaviour
{
    public int value1;
    public enum emAction
    {
        /*
        None,
        GetUp,
        Wash,
        Eat,
        Play,
        */
        None = 0,
        GetUp,
        Wash,
        Eat,
        Play,
    }

    public emAction emPlayer = emAction.Play;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Func1();
        Func2();
        //FuncEnum();
    }

    void Func1()
    {
        if (value1 == 1)
            Debug.Log("\n 1");
        else if (value1 == 2 || value1 == 3)
            Debug.Log("\n 23");
        else if (value1 == 4)
            Debug.Log("\n 4");
        else
            Debug.Log("\n out");
    }

    void Func2()
    {
        switch (emPlayer)
        {
            case emAction.Eat:
                Debug.Log("\n Eat");
                break;
            case emAction.GetUp:
                Debug.Log("\n GetUp");
                break;
            case emAction.Play:
                Debug.Log("\n Play");
                break;
            case emAction.Wash:
                Debug.Log("\n Wash");
                break;
            default:
                Debug.Log("\n None");
                break;
        }
    }

    void FuncEnum()
    {
        //Debug.Log(emPlayer);

        // enum <-> string

        //Debug.Log(emPlayer.ToString()); //enum -> string
       
        //emPlayer = (emAction)Enum.Parse(typeof(emAction), "Wash"); // 此处的wash必须在之前的Enum中已经定义了  
        //Debug.Log(emPlayer); // string -> enum

        // enum <-> int

        Debug.Log( (int)emPlayer );     // enum -> int

        emPlayer = (emAction)4;
        emPlayer = (emAction)Enum.ToObject(typeof(emAction), 1);
        Debug.Log(emPlayer);     // int -> enum
    }
}
