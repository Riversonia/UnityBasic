using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashTable : MonoBehaviour
{
    /*
        Hashtable 类代表了 基于键的哈希代码组织起来的 键-值对 集合
        它可以用来访问集合中的元素
     */
    Hashtable ht1 = new Hashtable();

    // Start is called before the first frame update
    void Start()
    {
        // 添加
        ht1.Add("1", 100);
        ht1.Add('f', 23);
        ht1.Add(1, 99);

        // 清除
        // ht1.Clear();
        if (ht1.ContainsKey("1"))
            Debug.Log("contain key 1");
        else
            Debug.Log("not contain key 1");

        Debug.Log(ht1.Count);

        // 删除
        ht1.Remove("1");
        Debug.Log(ht1["1"]);
        Debug.Log(ht1['f']);

        // 修改
        ht1[1] = 999;
        Debug.Log(ht1[1]);

        // 遍历输出
        ICollection key = ht1.Keys;
        foreach (var k in key)
            Debug.Log(ht1[k]);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
