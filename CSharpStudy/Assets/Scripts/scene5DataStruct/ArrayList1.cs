using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    ArrayList ��̬����
    ��̬������Զ��������Ĵ�С
    ����ʹ��������ָ��λ����ӻ����Ƴ���Ŀ�������б��н��ж�̬���� 
 */
public class ArrayList1 : MonoBehaviour
{
    ArrayList arrayList1 = new ArrayList();
    int[] array1 = new int[4] {1, 2, 3, 4 };


    // Start is called before the first frame update
    void Start()
    {
        arrayList1.Add("loj");
        arrayList1.Add("���");
        arrayList1.Add(25);
        arrayList1.Add(12);
        Debug.Log(arrayList1.Capacity);


        Debug.Log(arrayList1[0]);
        Debug.Log(arrayList1[1]);
        Debug.Log(arrayList1[2]);
        // ��arraylist1�б����������array1�е�ֵ
        arrayList1.AddRange(array1);

        // foreach ͨ������v ������̬����arrayList1�е�����Ԫ�ص�ֵ��
        // ÿ��ѭ�����������v������ǰ�����е�Ԫ��
        foreach (var v in arrayList1)
            Debug.Log(v);
        Debug.Log(arrayList1.Capacity);

        // ��ն�̬����
        // arrayList1.Clear();

        // �ж�arrayList���Ƿ���ָ��Ԫ�� ����bullֵ
        if (arrayList1.Contains(12))
            Debug.Log("\n Contain 12 ");
        else
            Debug.Log("\n not contain 12");

        // �ж�arrayList���Ƿ���ָ��Ԫ�� ����Ԫ�ص������±꣬�������ڷ�������-1
        Debug.Log(arrayList1.IndexOf(12));
        Debug.Log(arrayList1.IndexOf(9));

        // Insert��arraylist1�в���ָ������
        arrayList1.Insert(3, 66);
        foreach (var v in arrayList1)
            Debug.Log(v);

        // Removeɾ��arrayList1��ĳһԪ��
        arrayList1.Remove(25);
        foreach (var v in arrayList1)
            Debug.Log(v);

        // ��תԪ�� reverse
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
