using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// CS �ű��ļ����������ļ���������ͬ�������ܽ��ýű����ص� unity ������ִ��

// MonoBehaviour �� Unity ��һ�����ö���ĸ��� (parent class)
// ���ļ� Hello.cs �� Hello �̳и��� MonoBehaviour
public class Hello : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        short a = 10;
        short b = 20;
        // ͨ�� Unity �ṩ�� Debug �ӿ���־�������
        Debug.Log(" һ����־ ");
        Debug.Log("\na: " + a + "\nb: " + b);
        Debug.LogWarning(" ������־ ");
        Debug.LogError(" ������־ ");
    }

    // 1 ���� variable 
    //  <data_type> <variable_name> = value;\
    //  variable_name �����������շ�ʽ(������������)
    int hpValue = 1000;
    int iHpValue = 2000;    // i ���� int ����

    string strMonsterName = "NPCName";
    char chUnicode = 'a';   // ʹ�õ����� '', ����ʹ��˫���� ""
    bool bOpen = true;

    // C# ֧�ֵ���������
    /*
     * 1) ����ֵ���� 
     * uxxx ��ʾ�޷���
     * sbyte    -128 ~ 127
     * byte     0 ~ 255
     * short    -32 768 ~ 32 767
     * ushort   0 ~ 65535
     * int      -2 147 483 648 ~ 2 147 483 647
     * uint     0 ~
     * long     ����ȥ�ˣ�һ���ò���
     * ulong
     * 
     * 2) С���㡢������ֵ����
     * float    1.5 * 10^ -45 ~ 3.4 * 10^ 38
     * double   5.0 * 10^ -324 ~ 1.7 * 10^ 308
     * decimal  1.0 * 10^ -28 ~ 7.9 * 10^ 28
     * 
     * 3) ����ֵ����
     * char     ���һ���ַ� !@#$ ABCabc 1234 ����
     * bool  true / false
     * string   ���һ�� char �����飬 һ���ַ��ļ���
     */

    // Update is called once per frame
    void Update()
    {
        
    }
}
