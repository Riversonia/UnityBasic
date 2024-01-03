using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Runtime.InteropServices;
using UnityEngine;

public class LoopDemo : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Func1()
    {
        do
        {
            /*
             至少被执行一次
             */
        } while (true);

        while (true)
        {
            /*
             先判断后执行
             */
            break;
        }

        for (int i = 0; i < 10; i++)
        {
            continue;
            
            /*
            先判断后执行
            */
        }

        //int i = 0;
        //i++;
        //++i;

    }

    // Update is called once per frame
    void Update()
    {
        Func1();
    }
}
