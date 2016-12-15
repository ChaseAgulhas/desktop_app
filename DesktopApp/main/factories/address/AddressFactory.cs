/*
    Author: Ijaaz Lagardien
    Student Number: 214167542
    File: AddressFactory.cs
    Subject: Technical Programming 2
*/
using System;

namespace DesktopApp.main.factories.address
{
    public class AddressFactory
    {
        public static Address getAddress(String streetNumber, String streetName, String suburb, String city, String postCode)
        {
            Address address = new Address();
            address.StreetNumber = streetNumber;
            address.StreetName = streetName;
            address.Suburb = suburb;
            address.City = city;
            address.PostCode = postCode;
            return address; 
        }
    }
}
