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

namespace DesktopApp.main.domain
{
    [Serializable]
    class FoodItem : ISerializable
    {
        private String name;
        private double price;
        private int amountAvailable;

        public FoodItem(){}

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

        public class Builder
        {
            private String name;
            private double price;
            private int amountAvailable;

            public Builder() { }

            public Builder Name(String name)
            {
                this.name = name;
                return this;
            }

            public Builder Price(double price)
            {
                this.price = price;
                return this;
            }

            public Builder AmountAvailable(int amountAvailable)
            {
                this.amountAvailable = amountAvailable;
                return this;
            }

            public Builder copy(FoodItem foodItem)
            {
                this.name = foodItem.name;
                this.price = foodItem.price;
                this.amountAvailable = foodItem.amountAvailable;

                return this;
            }

            public FoodItem build() { return new FoodItem(); }
        }
    }
}
