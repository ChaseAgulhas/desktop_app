/*
    Author: Ijaaz Lagardien
    Student Number: 214167542
    File: DeliveryFactory.cs
    Subject: Technical Programming 2
*/
using DesktopApp.main.domain.delivery.impl;
using System;
namespace DesktopApp.main.factories.delivery
{
    public class DeliveryFactory
    {
        public static DeliveryImpl getDelivery(String destination, String description, String recipient, String dueTime , double distance)
        {
            DeliveryImpl deliveryOject = new DeliveryImpl();       
            deliveryOject.Destination = destination;
            deliveryOject.Description = description;
            deliveryOject.DueDate = dueTime;
            deliveryOject.Recipient = recipient;
            deliveryOject.TotalDistance = distance;
            return deliveryOject;                
        } 
    }
}
