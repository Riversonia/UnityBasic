using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInfo
{
    public string UserName;
    public string Password;
    public bool IsMale;

    public UserInfo(string userName, string password, bool isMale )
    {
        UserName = userName;
        Password = password;
        IsMale = isMale;
    }
}
public class GameManager 
{
    private static GameManager instance;

    public List<UserInfo> UserInfos = new List<UserInfo>();
    public static GameManager Instance
    {
        get
        {
            if (instance == null) instance = new GameManager();
            return instance;
        }
    }

    public void SaveUserInfo(UserInfo userInfo)
    {
        UserInfos.Add(userInfo);
    }

    public UserInfo GetUserInfo(string userName)
    {
        for(int i = 0; i != UserInfos.Count; i++)
        {
            if (userName == UserInfos[i].UserName)
                return UserInfos[i];
        }

        return null;
    }
}
