using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(" һ����־ ");
        Debug.LogWarning(" ������־ ");
        Debug.LogError(" ������־ ");

        string strPlayerName = "Peter";
        int iPlayerHpValue = 32500;
        short shPlayerLevel = 10;
        long lAdvantureExp = 114514;

        Debug.Log("Player Information \nName: " + strPlayerName + " Hp: " + iPlayerHpValue + " Level: " + shPlayerLevel + " Exp: " + lAdvantureExp);
        Debug.LogFormat("Player Information \nName: {0}, Hp: {1}, Level: {2}, Exp: {3}", strPlayerName, iPlayerHpValue, shPlayerLevel, lAdvantureExp);

        // Update is called once per frame
        void Update()
        {

        }
    }
}