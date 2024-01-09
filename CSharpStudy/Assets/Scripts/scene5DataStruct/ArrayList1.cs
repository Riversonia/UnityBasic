using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    ArrayList 动态数组
    动态数组会自动分配他的大小
    可以使用索引在指定位置添加或者移除项目，允许列表中进行动态分配 
 */
public class ArrayList1 : MonoBehaviour
{
    ArrayList arrayList1 = new ArrayList();
    int[] array1 = new int[4] {1, 2, 3, 4 };


    // Start is called before the first frame update
    void Start()
    {
        arrayList1.Add("loj");
        arrayList1.Add("你好");
        arrayList1.Add(25);
        arrayList1.Add(12);
        Debug.Log(arrayList1.Capacity);


        Debug.Log(arrayList1[0]);
        Debug.Log(arrayList1[1]);
        Debug.Log(arrayList1[2]);
        // 向arraylist1列表中添加数组array1中的值
        arrayList1.AddRange(array1);

        // foreach 通过变量v 遍历动态数组arrayList1中的所有元素的值，
        // 每次循环都会给变量v赋给当前集合中的元素
        foreach (var v in arrayList1)
            Debug.Log(v);
        Debug.Log(arrayList1.Capacity);

        // 清空动态数组
        // arrayList1.Clear();

        // 判断arrayList中是否含有指定元素 返回bull值
        if (arrayList1.Contains(12))
            Debug.Log("\n Contain 12 ");
        else
            Debug.Log("\n not contain 12");

        // 判断arrayList中是否含有指定元素 返回元素的索引下标，若不存在返回索引-1
        Debug.Log(arrayList1.IndexOf(12));
        Debug.Log(arrayList1.IndexOf(9));

        // Insert在arraylist1中插入指定数据
        arrayList1.Insert(3, 66);
        foreach (var v in arrayList1)
            Debug.Log(v);

        // Remove删除arrayList1中某一元素
        arrayList1.Remove(25);
        foreach (var v in arrayList1)
            Debug.Log(v);

        // 逆转元素 reverse
        Debug.Log("after reverse");
        arrayList1.Reverse();
        foreach (var v in arrayList1)
            Debug.Log(v);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
