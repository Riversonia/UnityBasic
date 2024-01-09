using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionary : MonoBehaviour
{
    /*
        �ֵ� �����������洢��ֵ�Ե���ϵļ���

        1�� �ֵ���һ�����ͣ�û��װ�������̣�ִ��Ч�ʸ�
            hashtable ��Ҫװ����䣬ִ��Ч����Խϵ�
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

        // ���� ��ֵ�Է��� keyValuePair
        foreach ( KeyValuePair<string, string> kvp in dic1)
            Debug.Log(kvp.Key + " " + kvp.Value);

        // ɾ��
        dic1.Remove("2");
        foreach (KeyValuePair<string, string> kvp in dic1)
            Debug.Log(kvp.Key + " " + kvp.Value);

        // ��ʽ�����
        // ��ʽ�����
        dic1.Clear();
        foreach (KeyValuePair<string, string> kvp in dic1)
            Debug.Log(kvp.Key + " " + kvp.Value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
