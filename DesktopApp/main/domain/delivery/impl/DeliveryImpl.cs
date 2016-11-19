/*
    Author: Ijaaz Lagardien
    Student Number: 214167542
    File: Delivery.cs
    Subject: Technical Programming 2
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace DesktopApp.main.domain.delivery.impl
{
    [Serializable]
    class DeliveryImpl : Delivery, ISerializable
    {
        private String destination;
        private String description;
        private String recipient;
        private String dueDate;
        private double totalDistance = 0.0;

        public DeliveryImpl(){}

        public string Destination
        {
            get{return destination;}
            set{destination = value;}
        }

        public string Description
        {
            get{return description;}
            set{description = value;}
        }

        public string Recipient
        {
            get{return recipient;}
            set{recipient = value;}
        }

        public string DueDate
        {
            get{return dueDate;}
            set{dueDate = value;}
        }

        public double TotalDistance
        {
            get{return totalDistance;}
            set{totalDistance = value;}
        }

        public double calculateTotalCost(double totalDistance)
        {
            double pricePerKm = 10.50;
            return totalDistance * pricePerKm;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
