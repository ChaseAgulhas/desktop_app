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
    class Vehicle : ISerializable
    {
        private String make;
        private String model;
        private String year;
        private String registrationNumber;
        private String owner;

        public Vehicle(){}

        public string Make
        {
            get{return make;}
            set{make = value;}
        }

        public string Model
        {
            get{return model;}
            set{model = value;}
        }

        public string Year
        {
            get{return year;}
            set{year = value;}
        }

        public string RegistrationNumber
        {
            get{ return registrationNumber;}
            set{ registrationNumber = value;}
        }

        public string Owner
        {
            get{return owner;}
            set{owner = value;}
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }

        private class Builder
        {
            private String make;
            private String model;
            private String year;
            private String registrationNumber;

            public Builder Make(String value)
            {
                this.make = value;
                return this;
            }

            public Builder Model(String value)
            {
                this.model = value;
                return this;
            }

            public Builder Year(String value)
            {
                this.year = value;
                return this;
            }

            public Builder RegistrationNumber(String value)
            {
                this.registrationNumber = value;
                return this;
            }

            public Builder copy(Vehicle value)
            {
                this.make = value.make;
                this.model = value.model;
                this.year = value.year;
                this.registrationNumber = value.registrationNumber;
                return this;
            }

            public Vehicle build()
            {
                return new Vehicle()
            }
        }
    }
}
