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
             ���ٱ�ִ��һ��
             */
        } while (true);

        while (true)
        {
            /*
             ���жϺ�ִ��
             */
            break;
        }

        for (int i = 0; i < 10; i++)
        {
            continue;
            
            /*
            ���жϺ�ִ��
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
