/*
    Author: Ijaaz Lagardien
    Student Number: 214167542
    File: Vehicle.cs
    Subject: Technical Programming 2
*/
using System;
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
    }
}
