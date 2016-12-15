/*
    Author: Ijaaz Lagardien
    Student Number: 214167542
    File: VehicleFactory.cs
    Subject: Technical Programming 2
*/
using DesktopApp.main.domain;
using System;

namespace DesktopApp.main.factories.vehicle
{
    public class VehicleFactory
    {
        public static Vehicle getVehicle(String make,String model,String year,String registrationNumber, String owner)
        {
            Vehicle vehicleObject = new Vehicle();
            vehicleObject.Make = make;
            vehicleObject.Model = model;
            vehicleObject.Year = year;
            vehicleObject.RegistrationNumber = registrationNumber;
            vehicleObject.Owner = owner;
            return vehicleObject;
        }
    }
}
