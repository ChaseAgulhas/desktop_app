/*
    Author: Ijaaz Lagardien
    Student Number: 214167542
    File: FoodItem.cs
    Subject: Technical Programming 2
*/
using System;
using System.Runtime.Serialization;

namespace DesktopApp.main.domain
{
    [Serializable]
    public class FoodItem : ISerializable
    {
        private String name;
        private double price;
        private int amountAvailable;

        public FoodItem(){}

        public FoodItem(String name, double price, int amountAvailable)
        {
            this.name = name;
            this.price = price;
            this.amountAvailable = amountAvailable;
        }

        public string Name
        {
            get{return name;}
            set{name = value;}
        }

        public double Price
        {
            get{return price;}
            set{price = value;}
        }

        public int AmountAvailable
        {
            get{return amountAvailable;}
            set{amountAvailable = value;}
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
