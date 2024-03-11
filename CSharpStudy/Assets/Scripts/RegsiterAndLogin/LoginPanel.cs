using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginPanel : MonoBehaviour
{
    public static LoginPanel Instance;

    #region Parameter 
    // InputField
    private InputField UserName;
    private InputField Password;

    // Button
    private Button BackButton;
    private Button LoginButton;
    #endregion

    #region Initial
    private void Awake()
    {
        Instance = this;

        // Initial
        UserName = transform.Find("UserName").GetComponent<InputField>();
        Password = transform.Find("Password").GetComponent<InputField>();

        BackButton = transform.Find("BackButton").GetComponent<Button>();
        LoginButton = transform.Find("LoginButton").GetComponent<Button>();

        BackButton.onClick.AddListener(BackButtonClick);
        LoginButton.onClick.AddListener(LoginButtonClick);

        gameObject.SetActive(false);
    }
    #endregion

    private void BackButtonClick()
    {
        gameObject.SetActive(false);
        MainPanel.Instance.Show();
    }

    private void LoginButtonClick()
    {
        if (string.IsNullOrEmpty(UserName.text)
            || string.IsNullOrEmpty(Password.text))
        {
            FloatWindow.Instance.ShowInfo("Input Username or Password!");
        }
        else
        {
            UserInfo userInfo = GameManager.Instance.GetUserInfo(UserName.text);
            if (userInfo == null)
                FloatWindow.Instance.ShowInfo("Username is not existed!");
            else if (userInfo.Password != Password.text)
                FloatWindow.Instance.ShowInfo("Username or Password Error!");
            else if (userInfo.Password == Password.text)
                FloatWindow.Instance.ShowInfo("Login Success!");
        }
    }
    public void Show()
    {
        gameObject.SetActive(true);
        UserName.text = "";
        Password.text = "";
    }
}
