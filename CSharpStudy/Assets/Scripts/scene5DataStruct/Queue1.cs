using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Queue1 : MonoBehaviour
{
    Queue q = new Queue();
    Queue<int> q1 = new Queue<int>();
    // Start is called before the first frame update
    void Start()
    {
        q1.Enqueue(1);  // 1
        q1.Enqueue(2);  // 1 -> 2
        q1.Enqueue(3);  // 1 -> 2 -> 3

        int v = q1.Dequeue();   // 2 -> 3
        Debug.Log(v);
        Debug.Log(q1.Count);

        foreach (var v1 in q1)
            Debug.Log(v1);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
