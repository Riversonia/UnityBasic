using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayDemo : MonoBehaviour
{
    // ���飺 �������ͬ��������Ԫ����ɵ����޼��ϣ��ڴ���������
    //  1. Ԫ������������������ͬ
    //  2. Ԫ����������
    //  3. �����±�������0��ʼ �±����� = �������� - 1
    // ����һ������  <data_type>[] variable_name;

    // ��ά���顢��ά����ͬ���±��������в�ͬ
    // Start is called before the first frame update
    void Start()
    {
        // ��������
        int[] array; // ��������������ϵͳû�з����ڴ�
        int[] array2 = new int[5]; // ���������ҷ������ڴ�
        // (1) ������ʸ�ֵ
        array2[0] = 10;
        // Debug.Log("\n [ԭʼ����] ���� array2 �е� 1 ������Ϊ: " + array2[0]);
        array2[0] = 15;
        // Debug.Log("\n [�޸�����] ���� array2 �е� 1 ������Ϊ: " + array2[0]);
        // array2[6] = 100; // ����������Խ����ʣ����벻�������б���

        // (2) �����ʼ��
        int[] array3 = new int[4] { 1, 2, 3, 4 }; // ������ʾ����
        int[] array4 = new int[ ] { 1, 2, 3, 4 }; // ������ʽ����
        int[] array5 = { 1, 2, 3, 4 };

        // (3) ���鳤�ȣ�������
        // Debug.Log("\n ���� array5 ������Ϊ: " + array5.Length);

        //----------
        // ��ά����
        // ���� 
        int[,] arr2d = new int[2, 3]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
        };
        // (1) ������ʸ�ֵ
        Debug.Log("\n [ԭʼ����] ���� arr2d �е� 1 �е� 2 �е�����Ϊ: " + arr2d[0, 1]);
        arr2d[0, 1] = 15;
        Debug.Log("\n [�޸�����] ���� arr2d �е� 1 �е� 2 �е�����Ϊ: " + arr2d[0, 1]);
        
        // (2) ��ȡ��ά��������
        Debug.Log("\n ���� arr2d ������Ϊ: " + arr2d.Length);
        Debug.Log("\n ���� arr2d ������Ϊ: " + arr2d.GetLength(0));
        Debug.Log("\n ���� arr2d ������Ϊ: " + arr2d.GetLength(1));

        //----------
        // ��ά����
        // ���� 
        int[,,] arr3d = new int[2, 3, 4];
        arr3d[0, 1, 2] = 10;
        // ��ά�����ʼ��һ����ú���������ֵ

        // (1) ������ʸ�ֵ
        Debug.Log("\n [ԭʼ����] ���� arr3d �е� 1 �е� 2 �е� 3 �������Ϊ: " + arr3d[0, 1, 2]);
        arr3d[0, 1, 2] = 15;
        Debug.Log("\n [�޸�����] ���� arr3d �е� 1 �е� 2 �е� 3 �������Ϊ: " + arr3d[0, 1, 2]);

        // (2) ��ȡ��ά��������
        Debug.Log("\n ���� arr3d ������Ϊ: " + arr3d.Length);
        Debug.Log("\n ���� arr3d ������Ϊ: " + arr3d.GetLength(0));
        Debug.Log("\n ���� arr3d ������Ϊ: " + arr3d.GetLength(1));
        Debug.Log("\n ���� arr3d �Ĳ���Ϊ: " + arr3d.GetLength(2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
