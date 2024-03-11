using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class RegsiterPanel : MonoBehaviour
{
    public static RegsiterPanel Instance;
    
    #region Parameter 

    // InputField
    private InputField UserName;
    private InputField Password;
    private InputField RePassword;

    // Toggle
    private Toggle IsMale;

    // Button
    private Button BackButton;
    private Button ConfirmButton;
    #endregion

    #region Initial
    private void Awake()
    {
        Instance = this;

        // Initial
        UserName = transform.Find("UserName").GetComponent<InputField>();
        Password = transform.Find("Password").GetComponent<InputField>();
        RePassword = transform.Find("RePassword").GetComponent<InputField>();

        IsMale = transform.Find("Sex/Male").GetComponent<Toggle>();

        BackButton = transform.Find("BackButton").GetComponent<Button>();
        ConfirmButton = transform.Find("ConfirmButton").GetComponent<Button>();

        BackButton.onClick.AddListener(BackButtonClick);
        ConfirmButton.onClick.AddListener(ConfirmButtonClick);

        gameObject.SetActive(false);
    }
    #endregion

    private void BackButtonClick()
    {
        gameObject.SetActive(false);
        MainPanel.Instance.Show();
    }

    private void ConfirmButtonClick()
    {
        if (string.IsNullOrEmpty(UserName.text)
            || string.IsNullOrEmpty(Password.text)
            || string.IsNullOrEmpty(RePassword.text))
        {
            FloatWindow.Instance.ShowInfo("Input Account or Password!");
        }
        else if(Password.text != RePassword.text)
        {
            FloatWindow.Instance.ShowInfo("Repeat Password Error!");
        }
        else 
        {
            if (GameManager.Instance.GetUserInfo(UserName.text) != null)
            {
                FloatWindow.Instance.ShowInfo("User Already Exists!");
            }
            else
            {
                // Save Users Infomation
                UserInfo userInfo = new UserInfo(UserName.text, Password.text, IsMale.isOn);
                GameManager.Instance.SaveUserInfo(userInfo);
                FloatWindow.Instance.ShowInfo("Regsiter Successful! Login it!");
            }
        }
    }

    public void Show()
    {
        gameObject.SetActive(true);

        // clear
        UserName.text = "";
        Password.text = "";
        RePassword.text = "";
        IsMale.isOn = true;
    }
}
