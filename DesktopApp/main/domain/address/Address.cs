﻿/*
    Author: Ijaaz Lagardien
    Student Number: 214167542
    File: Address.cs
    Subject: Technical Programming 2
*/
using System;
using System.Runtime.Serialization;

namespace DesktopApp.main
{
    [Serializable]
    public class Address : ISerializable
    {
        private String streetNumber;
        private String streetName;
        private String suburb;
        private String city;
        private String postCode;

        public Address(){}

        public Address(string streetNumber, string streetName, string suburb, string city, string postCode)
        {
            this.streetNumber = streetNumber;
            this.streetName = streetName;
            this.suburb = suburb;
            this.city = city;
            this.postCode = postCode;
        }

        public string StreetNumber
        {
            get{return streetNumber;}
            set{streetNumber = value;}
        }

        public string StreetName
        {
            get{return streetName;}
            set{streetName = value;}
        }

        public string Suburb
        {
            get{return suburb;}
            set{suburb = value;}
        }

        public string City
        {
            get{return city;}
            set{city = value;}
        }

        public string PostCode
        {
            get{return postCode;}
            set{postCode = value;}
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
