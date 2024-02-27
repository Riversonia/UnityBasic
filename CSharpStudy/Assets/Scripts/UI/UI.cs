using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 需要脚本操作UI，引入UnityEngine.UI相关的命名空间
using UnityEngine.UI;


public class UI : MonoBehaviour
{
    private Image image;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
