using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 ǰ��֪ʶ1��
    �������� string int[] class Interface               �Ѵ洢
    ֵ����   u-short u-int u-long bool enum struct      ջ�洢
        ����������洢ȡ����������λ�ã���ջ�洢��������
 ǰ��֪ʶ2�� 
    short   -32768 ~ 32767
    int     -2,147,483,648 ~ 2,147,483,647
    float   7λС��
    double  15-16λ

    1.is
        ���Լ�� ֵ���ͺ��������͡� �ɹ�����True ���򷵻�Fasle
    2.as
        �����ж�ԭ���������Ƿ���Ŀ���������ͣ����������ᱨ��
        ת���ɹ��᷵��Դ�������ʹ洢�����ݡ����򷵻�NULL
    3.ǿ������ת������ʽ����ת����
        1) �߾����������� -> �;�����������  ǿ������ת�� 
            ת��ʱ��Ҫע�� �߾��ȵ���������λ�� �� �;����������͵�λ�� �ķ�Χ�ڿ��Գɹ�ת��
    4.�Զ�����ת������ʽ����ת����
        1) �;����������� -> �߾�����������  ϵͳ�Զ�ת��
            ת��ʱ��Ҫע�� �;������ݲ�Ҫ�������ʾ��Χ
     
 */

/*
 װ��Ͳ���

    װ�� ֵ����ת��Ϊ��������
    ���� ��������ת��Ϊֵ����
 */
public class TypeChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //int a = 1234567;
        ////short b = a; //����
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
        object b = (object)a; // װ�䣬����GC �ڴ���� ���Բ��ӣ�object��

        int c = (int)b; // ���� object - >
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
