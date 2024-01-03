using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayDemo : MonoBehaviour
{
    // 数组： 有序的相同数据类型元素组成的有限集合，内存线性连续
    //  1. 元素数据类型与数据相同
    //  2. 元素数量有限
    //  3. 数组下标索引从0开始 下标索引 = 数组容量 - 1
    // 声明一个数组  <data_type>[] variable_name;

    // 二维数组、三维数组同理，下标索引略有不同
    // Start is called before the first frame update
    void Start()
    {
        // 数组声明
        int[] array; // 数组声明，但是系统没有分配内存
        int[] array2 = new int[5]; // 数组声明且分配了内存
        // (1) 数组访问赋值
        array2[0] = 10;
        // Debug.Log("\n [原始数据] 数组 array2 中第 1 个数据为: " + array2[0]);
        array2[0] = 15;
        // Debug.Log("\n [修改数据] 数组 array2 中第 1 个数据为: " + array2[0]);
        // array2[6] = 100; // 不允许数组越界访问，编译不报错，运行报错

        // (2) 数组初始化
        int[] array3 = new int[4] { 1, 2, 3, 4 }; // 容量显示声明
        int[] array4 = new int[ ] { 1, 2, 3, 4 }; // 容量隐式声明
        int[] array5 = { 1, 2, 3, 4 };

        // (3) 数组长度（容量）
        // Debug.Log("\n 数组 array5 的容量为: " + array5.Length);

        //----------
        // 二维数组
        // 声明 
        int[,] arr2d = new int[2, 3]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
        };
        // (1) 数组访问赋值
        Debug.Log("\n [原始数据] 数组 arr2d 中第 1 行第 2 列的数据为: " + arr2d[0, 1]);
        arr2d[0, 1] = 15;
        Debug.Log("\n [修改数据] 数组 arr2d 中第 1 行第 2 列的数据为: " + arr2d[0, 1]);
        
        // (2) 获取二维数组容量
        Debug.Log("\n 数组 arr2d 的容量为: " + arr2d.Length);
        Debug.Log("\n 数组 arr2d 的行数为: " + arr2d.GetLength(0));
        Debug.Log("\n 数组 arr2d 的列数为: " + arr2d.GetLength(1));

        //----------
        // 三维数组
        // 声明 
        int[,,] arr3d = new int[2, 3, 4];
        arr3d[0, 1, 2] = 10;
        // 高维数组初始化一般采用函数遍历赋值

        // (1) 数组访问赋值
        Debug.Log("\n [原始数据] 数组 arr3d 中第 1 行第 2 列第 3 层的数据为: " + arr3d[0, 1, 2]);
        arr3d[0, 1, 2] = 15;
        Debug.Log("\n [修改数据] 数组 arr3d 中第 1 行第 2 列第 3 层的数据为: " + arr3d[0, 1, 2]);

        // (2) 获取二维数组容量
        Debug.Log("\n 数组 arr3d 的容量为: " + arr3d.Length);
        Debug.Log("\n 数组 arr3d 的行数为: " + arr3d.GetLength(0));
        Debug.Log("\n 数组 arr3d 的列数为: " + arr3d.GetLength(1));
        Debug.Log("\n 数组 arr3d 的层数为: " + arr3d.GetLength(2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
