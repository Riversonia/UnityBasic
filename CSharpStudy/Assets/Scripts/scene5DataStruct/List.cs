using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    /*
     泛型集合 List<>, 指定类型
        作用于功能近似 arrayList
        无需拆箱装箱，类型转换
        类型安全，不存在类型异常
     
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
