using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class FloatWindow : MonoBehaviour
{
    public static FloatWindow Instance;

    private Text infoText;
    private Button confitmButton;

    private void Awake()
    {
        Instance = this;
        infoText = transform.Find("Info").GetComponent<Text>();
        confitmButton = transform.Find("ConfirmButton").GetComponent<Button>();
        confitmButton.onClick.AddListener(ConfirmButtonClick);
        ConfirmButtonClick();
    }

    public void ShowInfo(string info)
    {
        gameObject.SetActive(true);
        infoText.text = info;
    }

    private void ConfirmButtonClick()
    {
        gameObject.SetActive(false);
    }
}
