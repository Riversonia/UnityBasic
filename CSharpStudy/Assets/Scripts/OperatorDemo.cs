using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperatorDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Func1();
        //Func2();
        Func3();
    }

    void Func1()
    {
        int a = 6;
        int b = 4;
        // + - * /

        // % ȡ��
        int c = a % b;  // 6 % 4 = 2
        Debug.Log("\n" + c);

        // ++ -- 

       
    }

    void Func2()
    {
        // += -= *= /= %=
        // <<=  >>=

        int a = 8;  //          a(2) 0000 1000 = 8(10)
        a = a << 3; // ������λ  a(2) 0100 0000 = 64(10)
        Debug.Log("\n a :" + a);

        int b = 16; //          b(2) 0001 0000 = 16(10)
        b = b >> 2; // ������λ  b(2) 0000 0100 = 4(10)
        Debug.Log("\n b :" + b);

    }

    void Func3()
    {
        // ��ϵ���ʽ���߼�����
        // == >= <= != > <
        // && || !  �� �� ��
    }

    void Func4()
    {
        // <condition> ? <valueTrue> : <valueFalse>
        // ����Ϊ�棬����valueTrue�����򷵻�valueFalse
    }

    void Func5()
    {
        // λ�����
        /*
         &  ��λ�� and
        |   ��λ��  or
        ^   ��λ��� xor
        ~   ȡ��    not
         */
        int a = 60; // 60(2) 0011 1100
        int b = 13; // 13(2) 0000 1101
        int c = a & b; //    0000 1100 = 12(10)
        int d = a | b; //    0011 1101 = 61(10)
        int e = a ^ b; //    0011 0001 = 49(10)
        int f = ~a;    //    1100 0011 = -61(10) ����ȡ������һλΪ����λ
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
