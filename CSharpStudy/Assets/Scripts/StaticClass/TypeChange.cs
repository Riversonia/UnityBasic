using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 前置知识1：
    引用类型 string int[] class Interface               堆存储
    值类型   u-short u-int u-long bool enum struct      栈存储
        数据在哪里存储取决于声明的位置，堆栈存储并不绝对
 前置知识2： 
    short   -32768 ~ 32767
    int     -2,147,483,648 ~ 2,147,483,647
    float   7位小数
    double  15-16位

    1.is
        可以检测 值类型和引用类型。 成功返回True 否则返回Fasle
    2.as
        首先判断原数据类型是否是目标数据类型，如果不是则会报错；
        转换成功会返回源数据类型存储的数据。否则返回NULL
    3.强制类型转换（显式类型转换）
        1) 高精度数据类型 -> 低精度数据类型  强制类型转换 
            转换时需要注意 高精度的数据类型位数 在 低精度数据类型的位数 的范围内可以成功转换
    4.自动类型转换（隐式类型转换）
        1) 低精度数据类型 -> 高精度数据类型  系统自动转换
            转换时需要注意 低精度数据不要超过其表示范围
     
 */

/*
 装箱和拆箱

    装箱 值类型转换为引用类型
    拆箱 引用类型转换为值类型
 */
public class TypeChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //int a = 1234567;
        ////short b = a; //报错
        //short b = (short)a;
        //Debug.Log("\n" + b);

        //string strA = "abc";
        //int c = 123;

        //bool d = strA is string;
        //Debug.Log(d);

        //string a = "abc";
        //int b = 123;
        //string c = a as string;
        //Debug.Log(c);

        int a = 20;
        object b = (object)a; // 装箱，发生GC 内存分配 可以不加（object）

        int c = (int)b; // 拆箱 object - >
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
