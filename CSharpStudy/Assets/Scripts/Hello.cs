using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// CS 脚本文件名必须于文件中类名相同，否则不能将该脚本挂载到 unity 对象上执行

// MonoBehaviour 是 Unity 的一个内置定义的父类 (parent class)
// 新文件 Hello.cs 中 Hello 继承父类 MonoBehaviour
public class Hello : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        short a = 10;
        short b = 20;
        // 通过 Unity 提供的 Debug 接口日志调用输出
        Debug.Log(" 一般日志 ");
        Debug.Log("\na: " + a + "\nb: " + b);
        Debug.LogWarning(" 警告日志 ");
        Debug.LogError(" 错误日志 ");
    }

    // 1 变量 variable 
    //  <data_type> <variable_name> = value;\
    //  variable_name 命名方法：驼峰式(匈牙利命名法)
    int hpValue = 1000;
    int iHpValue = 2000;    // i 代表 int 类型

    string strMonsterName = "NPCName";
    char chUnicode = 'a';   // 使用单引号 '', 不能使用双引号 ""
    bool bOpen = true;

    // C# 支持的数据类型
    /*
     * 1) 整数值类型 
     * uxxx 表示无符号
     * sbyte    -128 ~ 127
     * byte     0 ~ 255
     * short    -32 768 ~ 32 767
     * ushort   0 ~ 65535
     * int      -2 147 483 648 ~ 2 147 483 647
     * uint     0 ~
     * long     大了去了，一般用不到
     * ulong
     * 
     * 2) 小数点、浮点数值类型
     * float    1.5 * 10^ -45 ~ 3.4 * 10^ 38
     * double   5.0 * 10^ -324 ~ 1.7 * 10^ 308
     * decimal  1.0 * 10^ -28 ~ 7.9 * 10^ 28
     * 
     * 3) 非数值类型
     * char     存放一个字符 !@#$ ABCabc 1234 文字
     * bool  true / false
     * string   存放一个 char 的数组， 一个字符的集合
     */

    // Update is called once per frame
    void Update()
    {
        
    }
}
