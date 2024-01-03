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

        // % 取余
        int c = a % b;  // 6 % 4 = 2
        Debug.Log("\n" + c);

        // ++ -- 

       
    }

    void Func2()
    {
        // += -= *= /= %=
        // <<=  >>=

        int a = 8;  //          a(2) 0000 1000 = 8(10)
        a = a << 3; // 左移三位  a(2) 0100 0000 = 64(10)
        Debug.Log("\n a :" + a);

        int b = 16; //          b(2) 0001 0000 = 16(10)
        b = b >> 2; // 右移两位  b(2) 0000 0100 = 4(10)
        Debug.Log("\n b :" + b);

    }

    void Func3()
    {
        // 关系表达式、逻辑符号
        // == >= <= != > <
        // && || !  且 或 非
    }

    void Func4()
    {
        // <condition> ? <valueTrue> : <valueFalse>
        // 条件为真，返回valueTrue，否则返回valueFalse
    }

    void Func5()
    {
        // 位运算符
        /*
         &  按位与 and
        |   按位或  or
        ^   按位异或 xor
        ~   取反    not
         */
        int a = 60; // 60(2) 0011 1100
        int b = 13; // 13(2) 0000 1101
        int c = a & b; //    0000 1100 = 12(10)
        int d = a | b; //    0011 1101 = 61(10)
        int e = a ^ b; //    0011 0001 = 49(10)
        int f = ~a;    //    1100 0011 = -61(10) 符号取反，第一位为符号位
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
