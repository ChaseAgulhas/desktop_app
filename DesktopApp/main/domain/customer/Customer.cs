/*
    Author: Ijaaz Lagardien
    Student Number: 214167542
    File: Customer.cs
    Subject: Technical Programming 2
*/
using System;
using System.Runtime.Serialization;

namespace DesktopApp.main.domain
{
    [Serializable]
    public class Customer : ISerializable
    {
        private String name, surname, phoneNumber;

        public Customer(){}

        public Customer(String name, String surname, String phoneNumber)
        {
            this.name = name;
            this.surname = surname;
            this.phoneNumber = phoneNumber;
        }

        public string Name
        {
            get{return name;}
            set{name = value;}
        }

        public string PhoneNumber
        {
            get{return phoneNumber;}
            set{phoneNumber = value;}
        }

        public string Surname
        {
            get{return surname;}
            set{surname = value;}
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
