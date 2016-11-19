/*
    Author: Ijaaz Lagardien
    Student Number: 214167542
    File: Driver.cs
    Subject: Technical Programming 2
*/
using System;
using System.Runtime.Serialization;

namespace DesktopApp.main.domain
{
    [Serializable]
    class Driver : ISerializable
    {
        private String name;
        private String surname;
        private String cellPhoneNumber;
        private String email;
        private String password;
        private byte[] profilePhoto;

        public Driver(){}

        public string Name
        {
            get
            {return name;}
            set
            {name = value;}
        }

        public string Surname
        {
            get
            {return surname;}

            set
            {surname = value;}
        }

        public string CellPhoneNumber
        {
            get
            {return cellPhoneNumber;}

            set
            {cellPhoneNumber = value;}
        }

        public string Email
        {
            get{return email;}

            set{email = value;}
        }

        public string Password
        {
            get{return password;}

            set{password = value;}
        }

        public byte[] ProfilePhoto
        {
            get{return profilePhoto;}

            set{profilePhoto = value;}
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }

        private class Builder
        {
            private String name;
            private String surname;
            private String cellPhoneNumber;
            private String email;
            private String password;
            private byte[] profilePhoto;


            public Builder Name(String value)
            {
                this.name = value;
                return this;
            }

            public Builder Surname(String value)
            {
                this.surname = value;
                return this;
            }

            public Builder CellPhoneNumber(String value)
            {
                this.cellPhoneNumber = value;
                return this;
            }

            public Builder Email(String value)
            {
                this.email = value;
                return this;
            }

            public Builder Password(String value)
            {
                this.password = value;
                return this;
            }

            public Builder ProfilePhoto(byte[] value)
            {
                this.profilePhoto = value;
                return this;
            }

            public Builder copy(Driver value)
            {
                this.name = value.name;
                this.surname = value.surname;
                this.cellPhoneNumber = value.cellPhoneNumber;
                this.email = value.email;
                this.password = value.password;
                this.profilePhoto = value.profilePhoto;
                return this;
            }

            public Driver build()
            {
                return new Driver();
            }
        }
    }
}
