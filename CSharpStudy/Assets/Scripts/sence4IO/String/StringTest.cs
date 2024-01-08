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

        // 2 �ַ����ȽϷ�ʽcompare equel
        // �ַ��� �Դ�Сд����
        // ���str1 = str2 ���0�� ��0�������
        Debug.Log(string.Compare(str, str2));

        //                                  ���Դ�Сд true
        Debug.Log(string.Compare(str, str2, true));

        Debug.Log(string.Equals(str, str2));
        Debug.Log(str.Equals(str2));

        // 3 �ַ���ƴ��
        Debug.Log(string.Concat(str, str2));
        Debug.Log(str + str2);
        Debug.Log(string.Format("name:{0}, age:{1}", "zhangsan", 14));

        // 4 �ж��ַ������Ƿ����Ŀ���ַ�/�ַ���
        Debug.Log(str.Contains("lo"));
        // Debug.Log(str.Contains('L')); //�ַ�������Contains

        // ����
        Debug.Log(str.IndexOf("l"));
        Debug.Log(str.LastIndexOf("l")); // ���һ�γ��� ��λ������

        // �жϿ�ͷ
        Debug.Log(str.StartsWith("h")); // true  
        Debug.Log(str.StartsWith("H")); // false startsWith�Դ�Сд����

        // �жϽ�β
        Debug.Log(str.EndsWith("o"));

        // 5 ����
        Debug.Log(str.Insert(2, "1456\n") + str); // ���벻�Ḳ��ԭ���ַ���

        // 6 static IsNullOrEmpty
        Debug.Log(string.IsNullOrEmpty(str));
        Debug.Log(string.IsNullOrEmpty(str3));

        // 7 remove
        Debug.Log(str.Remove(0, 2) + str);  // ���Ḳ��ԭ���ַ���

        // 8 replace 
        Debug.Log(str.Replace("h", "Hdc1") + str); // ���Ḳ��ԭ���ַ���

        // 9 �и�
        string [] array = str.Split(new char[] {'e'});
        for (int i = 0; i < array.Length; i++)
            Debug.Log(i + array[i] + "\n");

        // 10 ToLower/ToUpper ���ַ�����ĸ��Ϊ��Сд
        Debug.Log(str2.ToLower() + "\n" + str2.ToUpper());

        // 11 Trim ȥ���ո�
        string str4 = " h e l lo";
        Debug.Log(str4.Trim());
    }
}
