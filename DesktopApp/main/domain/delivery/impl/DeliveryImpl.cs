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

        private class Builder
        {
            private String destinations;
            private String descriptions;
            private String recipients;
            private String dueDates;
            private double totalDistance = 0.0;

            public Builder Destination(String values)
            {
                this.destinations = values;
                return this;
            }

            public Builder Description(String values)
            {
                this.descriptions = values;
                return this;
            }

            public Builder TotalDistance(double value)
            {
                this.totalDistance = value;
                return this;
            }

            public Builder Recipients(String values)
            {
                this.recipients = values;
                return this;
            }

            public Builder DueDate(String values)
            {
                this.dueDates = values;
                return this;
            }



            public Builder copy(DeliveryImpl value)
            {
                this.destinations = value.destination;
                this.descriptions = value.description;
                this.totalDistance = value.totalDistance;
                this.dueDates = value.dueDate;
                this.recipients = value.recipient;
                return this;
            }

            public DeliveryImpl build()
            {
                return new DeliveryImpl();
            }
        }
    }
}
