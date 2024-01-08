using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Text;


/*
    string �� stringBuilder ������
    string          ���ɸı�
    stringBuilder   �ڵײ�ά����һ�����飬��ʱ��������������ڶ�ջ�Ͽ������ڴ�
    
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

        // 1 ��ӡsb���Ⱥ�����
        Debug.Log(sb.Length + " " + sb.Capacity);

        // 2 ���õ�API
        // 2.1 Append
        sb = sb.Append("123");
        Debug.Log(sb);

        // 2.2 AppendFormat ��ʽ��׷��
        sb = sb.AppendFormat("{0}", "456");
        Debug.Log(sb);
        Debug.Log(sb.ToString());

        // 2.3  Insert ָ��λ�ò���
        sb = sb.Insert(6, "nihao");
        Debug.Log(sb);

        // 2.4 Remove ɾ��ָ��λ��
        sb = sb.Remove(6, 5);
        sb = sb.Remove(11, 6);
        Debug.Log(sb);

        // 2.5 replace �滻ָ������
        sb = sb.Replace("wor", "WOR");
        Debug.Log(sb);

        // ��ʽ׷�ӱ��
        sb = sb.Append("123").Append("456").Replace("2", "7");
        Debug.Log(sb);
    }
}
