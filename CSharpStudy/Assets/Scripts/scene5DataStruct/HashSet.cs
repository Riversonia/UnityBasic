using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    ���㼯�ϵĽ������ȽϷ���
    hashset �������ظ��������б�
 
 */

public class HashSet : MonoBehaviour
{
    HashSet<int> hs1 = new HashSet<int>();
    HashSet<int> hs2 = new HashSet<int>();

    // Start is called before the first frame update
    void Start()
    {
        hs1.Add(1);
        hs1.Add(2);
        hs1.Add(2); // ����ظ��������ӳ���
        hs1.Add(3);

        Debug.Log(hs1.Count); // 3

        hs2.Add(2);
        hs2.Add(3);
        hs2.Add(4);

        //hs1.IntersectWith(hs2); // ����
        //hs1.UnionWith(hs2);     // ����
        //hs1.ExceptWith(hs2);    // �
        hs1.SymmetricExceptWith(hs2);   // �ԳƲ
        foreach (var v in hs1)
            Debug.Log(v);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
