using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class StringTest : MonoBehaviour
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
        string str = "hello";
        string str2 = "HEllo";
        string str3 = "";

        // 1 length
        Debug.Log(str.Length);

        // 2 字符串比较方式compare equel
        // 字符串 对大小写敏感
        // 如果str1 = str2 输出0， 非0代表不相等
        Debug.Log(string.Compare(str, str2));

        //                                  忽略大小写 true
        Debug.Log(string.Compare(str, str2, true));

        Debug.Log(string.Equals(str, str2));
        Debug.Log(str.Equals(str2));

        // 3 字符串拼接
        Debug.Log(string.Concat(str, str2));
        Debug.Log(str + str2);
        Debug.Log(string.Format("name:{0}, age:{1}", "zhangsan", 14));

        // 4 判断字符串中是否存在目标字符/字符串
        Debug.Log(str.Contains("lo"));
        // Debug.Log(str.Contains('L')); //字符不能用Contains

        // 索引
        Debug.Log(str.IndexOf("l"));
        Debug.Log(str.LastIndexOf("l")); // 最后一次出现 的位置索引

        // 判断开头
        Debug.Log(str.StartsWith("h")); // true  
        Debug.Log(str.StartsWith("H")); // false startsWith对大小写敏感

        // 判断结尾
        Debug.Log(str.EndsWith("o"));

        // 5 插入
        Debug.Log(str.Insert(2, "1456\n") + str); // 插入不会覆盖原有字符串

        // 6 static IsNullOrEmpty
        Debug.Log(string.IsNullOrEmpty(str));
        Debug.Log(string.IsNullOrEmpty(str3));

        // 7 remove
        Debug.Log(str.Remove(0, 2) + str);  // 不会覆盖原有字符串

        // 8 replace 
        Debug.Log(str.Replace("h", "Hdc1") + str); // 不会覆盖原有字符串

        // 9 切割
        string [] array = str.Split(new char[] {'e'});
        for (int i = 0; i < array.Length; i++)
            Debug.Log(i + array[i] + "\n");

        // 10 ToLower/ToUpper 将字符串字母改为大小写
        Debug.Log(str2.ToLower() + "\n" + str2.ToUpper());

        // 11 Trim 去掉空格
        string str4 = " h e l lo";
        Debug.Log(str4.Trim());
    }
}
