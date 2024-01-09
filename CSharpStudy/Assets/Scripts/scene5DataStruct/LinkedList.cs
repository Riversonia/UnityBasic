using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    ���� list ����
        ɾ��Ч���������O(1) ����ʱЧ�ʽϵ�O(n)
    
 
 */

public class LinkedList : MonoBehaviour
{
    // ˫������ 

    LinkedList<int> linkedList1 = new LinkedList<int>();
    LinkedListNode<int> node;

    // Start is called before the first frame update
    void Start()
    {
        node = linkedList1.AddFirst(1);         // �׽ڵ� 1
        linkedList1.AddAfter(node, 2);          // 1 -> 2
        node = linkedList1.AddBefore(node, 0);  // 0 -> 1 -> 2

        Debug.Log(linkedList1.Count);
        Debug.Log(linkedList1.First.Value);
        Debug.Log(linkedList1.Last.Value);

        if (node.Previous != null)
            Debug.Log(node.Previous.Value);
        else
            Debug.Log("node has not previous value");

        if (node.Next!= null)
            Debug.Log(node.Next.Value);
        else
            Debug.Log("node has not Next value");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
