/*
    Author: Ijaaz Lagardien
    Student Number: 214167542
    File: LoginFactory.cs
    Subject: Technical Programming 2
*/
using DesktopApp.main.domain;
using System;

namespace DesktopApp.main.factories.login
{
    class LoginFactory
    {
        public static Login getLogin(String username,String password)
        {
            Login loginObject = new Login();
            loginObject.Username = username;
            loginObject.Password = password;
            return loginObject;
        }
    }
}
