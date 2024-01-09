using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashTable : MonoBehaviour
{
    /*
        Hashtable ������� ���ڼ��Ĺ�ϣ������֯������ ��-ֵ�� ����
        �������������ʼ����е�Ԫ��
     */
    Hashtable ht1 = new Hashtable();

    // Start is called before the first frame update
    void Start()
    {
        // ���
        ht1.Add("1", 100);
        ht1.Add('f', 23);
        ht1.Add(1, 99);

        // ���
        // ht1.Clear();
        if (ht1.ContainsKey("1"))
            Debug.Log("contain key 1");
        else
            Debug.Log("not contain key 1");

        Debug.Log(ht1.Count);

        // ɾ��
        ht1.Remove("1");
        Debug.Log(ht1["1"]);
        Debug.Log(ht1['f']);

        // �޸�
        ht1[1] = 999;
        Debug.Log(ht1[1]);

        // �������
        ICollection key = ht1.Keys;
        foreach (var k in key)
            Debug.Log(ht1[k]);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
