using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    /*
     ���ͼ��� List<>, ָ������
        �����ڹ��ܽ��� arrayList
        �������װ�䣬����ת��
        ���Ͱ�ȫ�������������쳣
     
     */
    List<int> list1 = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        list1.Add(1);
        list1.Add(2);
        list1.Add(3);

        Debug.Log(list1.Count);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
