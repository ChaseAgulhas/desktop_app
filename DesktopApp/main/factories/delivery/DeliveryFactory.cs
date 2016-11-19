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
    class DeliveryFactory
    {
        public static DeliveryImpl getDelivery(String description,String destination, String dueTime, String recipient, double distance)
        {
            DeliveryImpl deliveryOject = new DeliveryImpl();
            deliveryOject.Description = description;
            deliveryOject.Destination = destination;
            deliveryOject.DueDate = dueTime;
            deliveryOject.Recipient = recipient;
            deliveryOject.TotalDistance = distance;
            return deliveryOject;                
        } 
    }
}
