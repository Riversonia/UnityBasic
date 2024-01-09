using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    计算集合的交并集比较方便
    hashset 包含不重复的无序列表
 
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
        hs1.Add(2); // 添加重复不会增加长度
        hs1.Add(3);

        Debug.Log(hs1.Count); // 3

        hs2.Add(2);
        hs2.Add(3);
        hs2.Add(4);

        //hs1.IntersectWith(hs2); // 交集
        //hs1.UnionWith(hs2);     // 并集
        //hs1.ExceptWith(hs2);    // 差集
        hs1.SymmetricExceptWith(hs2);   // 对称差集
        foreach (var v in hs1)
            Debug.Log(v);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
