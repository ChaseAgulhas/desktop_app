/*
    Author: Ijaaz Lagardien
    Student Number: 214167542
    File: CustomerFactory.cs
    Subject: Technical Programming 2
*/
using DesktopApp.main.domain;
using System;

namespace DesktopApp.main.factories.customer
{
    public class CustomerFactory
    {
        public static Customer getCustomer(String name, String surname,String phoneNumber) 
        {
            Customer customerObject = new Customer();
            customerObject.Name = name;
            customerObject.Surname = surname;
            customerObject.PhoneNumber = phoneNumber;
            return customerObject;
        }
    }
}
