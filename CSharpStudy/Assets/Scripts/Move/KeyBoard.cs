using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBoard : MonoBehaviour
{
    public string AttackKeyName = "a";
    private float AttackValue = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        #region ��������
        //����
        //if (Input.GetKeyDown(AttackKeyName))
        //{
        //    print("start attack");
        //    AttackValue = 0.0f;
        //}

        //if (Input.GetKey(AttackKeyName))
        //{
        //    print("delay");
        //    AttackValue += Time.deltaTime;
        //}

        //if (Input.GetKeyUp(AttackKeyName))
        //{
        //    print("hit: " + AttackValue);

        //}
        #endregion

        #region ���̰������
        //����
        //if (Input.GetKey(AttackKeyName))
        //    print("Attack");
        //if(Input.GetKeyDown(KeyCode.A))
        //    print("press A");
        //if (Input.GetKeyUp(KeyCode.A))
        //    print("free A");
        //if (Input.GetKey(KeyCode.A))
        //    print("stay pressed A");
        #endregion

        #region ��갴�����
        /* 0 left  1 right
        GetMouseButtonDown   //����
        GetMouseButtonUp     //�ͷ�
         GetMouseButton       //������ס
        */

        //if(Input.GetMouseButtonDown(0))
        //{
        //    print("left");

        //    // ���λ�����
        //    print("Mouse Position: " + Input.mousePosition);
        //}
        //if (Input.GetMouseButton(1))
        //{
        //    print("right");
        //}


        #endregion

 
    }
}
