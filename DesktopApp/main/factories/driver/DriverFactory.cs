/*
    Author: Ijaaz Lagardien
    Student Number: 214167542
    File: DriverFactory.cs
    Subject: Technical Programming 2
*/
using DesktopApp.main.domain;
using System;

namespace DesktopApp.main.factories.driver
{
    class DriverFactory
    {
        public static Driver getDriver(String name, String surname,String cellphoneNumber,String email,String password, byte[] profilePhoto)
        {
            Driver driverObject = new Driver();
            driverObject.Name = name;
            driverObject.Surname = surname;
            driverObject.CellPhoneNumber = cellphoneNumber;
            driverObject.Email = email;
            driverObject.Password = password;
            driverObject.ProfilePhoto = profilePhoto;
            return driverObject;
        }
    }
}
