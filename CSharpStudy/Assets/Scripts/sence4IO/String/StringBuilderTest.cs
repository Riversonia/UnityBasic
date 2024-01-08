using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Text;


/*
    string 和 stringBuilder 的区别
    string          不可改变
    stringBuilder   在底层维护了一个数组，随时检测容量，不会在堆栈上开辟新内存
    
 */
public class StringBuilderTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Test1();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Test1()
    {
        StringBuilder sb = new StringBuilder("Hello world");
        sb.Capacity = 25;

        // 1 打印sb长度和容量
        Debug.Log(sb.Length + " " + sb.Capacity);

        // 2 常用的API
        // 2.1 Append
        sb = sb.Append("123");
        Debug.Log(sb);

        // 2.2 AppendFormat 格式化追加
        sb = sb.AppendFormat("{0}", "456");
        Debug.Log(sb);
        Debug.Log(sb.ToString());

        // 2.3  Insert 指定位置插入
        sb = sb.Insert(6, "nihao");
        Debug.Log(sb);

        // 2.4 Remove 删除指定位置
        sb = sb.Remove(6, 5);
        sb = sb.Remove(11, 6);
        Debug.Log(sb);

        // 2.5 replace 替换指定对象
        sb = sb.Replace("wor", "WOR");
        Debug.Log(sb);

        // 链式追加表达
        sb = sb.Append("123").Append("456").Replace("2", "7");
        Debug.Log(sb);
    }
}
