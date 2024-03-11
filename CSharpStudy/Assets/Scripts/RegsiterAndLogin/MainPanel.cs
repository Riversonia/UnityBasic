using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainPanel : MonoBehaviour
{
    public static MainPanel Instance;

    private Button regsiterButton;
    private Button loginButton;

    private void Awake()
    {
        Instance = this;

        regsiterButton = transform.Find("RegsiterButton").GetComponent<Button>();
        loginButton = transform.Find("LoginButton").GetComponent<Button>();

        regsiterButton.onClick.AddListener(RegsiterButtonClick);
        loginButton.onClick.AddListener(LoginButtonClick);
    }

    private void RegsiterButtonClick()
    {
        RegsiterPanel.Instance.Show();
        gameObject.SetActive(false);
    }
    private void LoginButtonClick()
    {
        LoginPanel.Instance.Show();
        gameObject.SetActive(false);
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

}
