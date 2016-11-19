/*
    Author: Ijaaz Lagardien
    Student Number: 214167542
    File: Login.cs
    Subject: Technical Programming 2
*/
using System;
using System.Runtime.Serialization;

namespace DesktopApp.main.domain
{
    [Serializable]
    class Login : ISerializable
    {
        private String username;
        private String password;

        public Login(){ }

        public string Username
        {
            get{return username;}
            set{username = value;}
        }

        public string Password
        {
            get{return password;}

            set{password = value;}
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }

    }
}
