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
        #region 键盘蓄力
        //蓄力
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

        #region 键盘按键检测
        //按下
        //if (Input.GetKey(AttackKeyName))
        //    print("Attack");
        //if(Input.GetKeyDown(KeyCode.A))
        //    print("press A");
        //if (Input.GetKeyUp(KeyCode.A))
        //    print("free A");
        //if (Input.GetKey(KeyCode.A))
        //    print("stay pressed A");
        #endregion

        #region 鼠标按键检测
        /* 0 left  1 right
        GetMouseButtonDown   //按下
        GetMouseButtonUp     //释放
         GetMouseButton       //持续按住
        */

        //if(Input.GetMouseButtonDown(0))
        //{
        //    print("left");

        //    // 鼠标位置输出
        //    print("Mouse Position: " + Input.mousePosition);
        //}
        //if (Input.GetMouseButton(1))
        //{
        //    print("right");
        //}


        #endregion

 
    }
}
