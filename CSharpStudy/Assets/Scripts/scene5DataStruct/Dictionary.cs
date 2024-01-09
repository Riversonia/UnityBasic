using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionary : MonoBehaviour
{
    /*
        字典 泛型容器，存储键值对的组合的集合

        1） 字典是一个泛型，没有装箱拆箱过程，执行效率高
            hashtable 需要装箱拆箱，执行效率相对较低
     */

    Dictionary<string, string> dic1 = new Dictionary<string, string>();

    // Start is called before the first frame update
    void Start()
    {
        dic1.Add("1", "100");
        dic1.Add("2", "200");
        dic1.Add("3", "250");

        if (dic1.ContainsKey("1"))
            Debug.Log("contain key 1");
        else
            Debug.Log("not contain key 1");
        
        dic1["1"] = "150";

        // 遍历 键值对泛型 keyValuePair
        foreach ( KeyValuePair<string, string> kvp in dic1)
            Debug.Log(kvp.Key + " " + kvp.Value);

        // 删除
        dic1.Remove("2");
        foreach (KeyValuePair<string, string> kvp in dic1)
            Debug.Log(kvp.Key + " " + kvp.Value);

        // 格式化清除
        // 格式化清除
        dic1.Clear();
        foreach (KeyValuePair<string, string> kvp in dic1)
            Debug.Log(kvp.Key + " " + kvp.Value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
