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

    interface Delivery
    {
        double calculateTotalCost(double totalDistance);
    }
}
