/*
    Author: Ijaaz Lagardien
    Student Number: 214167542
    File: Address.cs
    Subject: Technical Programming 2
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private class Builder
        {
            private String username;
            private String password;

            public Builder() { }

            public Builder Username(String username)
            {
                this.username = username;
                return this;
            }

            public Builder Password(String password)
            {
                this.password = password;
                return this;
            }

            public Builder copy(Login login)
            {
                this.username = login.username;
                this.password = login.password;
                return this;
            }

            public Login build() { return new Login(); }
        }
    }
}
