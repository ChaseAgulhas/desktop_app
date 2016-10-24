/*
    Author: Ijaaz Lagardien
    Student Number: 214167542
    File: Customer.cs
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
    class Customer : ISerializable
    {
        private String name, surname, phoneNumber;

        public Customer(){}

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

        private  class Builder
        {
            private String name;
            private String surname;
            private String phoneNumber;

            public Builder() { }

            public Builder Name(String name)
            {
                this.name = name;
                return this;
            }

            public Builder Surname(String surname)
            {
                this.surname = surname;
                return this;
            }

            public Builder PhoneNumber(String phoneNumber)
            {
                this.phoneNumber = phoneNumber;
                return this;
            }

            public Builder copy(Customer customer)
            {
                this.name = customer.name;
                this.surname = customer.surname;
                this.phoneNumber = customer.phoneNumber;
                return this;
            }

            public Customer build()
            {
                return new Customer();
            }
        }
    }
}
