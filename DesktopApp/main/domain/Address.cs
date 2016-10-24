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

namespace DesktopApp.main
{
    [Serializable]
    class Address : ISerializable
    {
        private String streetNumber;
        private String streetName;
        private String suburb;
        private String city;
        private String postCode;

        public Address(){}

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

        private class Builder
        {
            public Builder(){}
            private String streetNumber;
            private String streetName;
            private String suburb;
            private String city;
            private String postCode;

            public Builder StreetNumber(String streetNumber)
            {
                this.streetNumber = streetNumber;
                return this;
            }

            public Builder StreetName(String streetName)
            {
                this.streetName = streetName;
                return this;
            }

            public Builder Suburb(String suburb)
            {
                this.suburb = suburb;
                return this;
            }

            public Builder City(String city)
            {
                this.city = city;
                return this;
            }

            public Builder PostCode(String postCode)
            {
                this.postCode = postCode;
                return this;
            }

            public Builder copy(Address address)
            {
                this.streetNumber = address.StreetNumber;
                this.streetName = address.StreetName;
                this.suburb = address.Suburb;
                this.city = address.City;
                this.postCode = address.PostCode;

                return this;
            }

            public Address build()
            {
                return new Address();
            }
        }
   
    }
}
