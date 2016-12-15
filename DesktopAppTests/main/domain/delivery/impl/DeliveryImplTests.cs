using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesktopApp.main.domain.delivery.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.main.domain.delivery.impl.Tests
{
    [TestClass()]
    public class DeliveryImplTests
    {
        [TestMethod()]
        public void DeliveryImplTest()
        {
            DeliveryImpl delivery = new DeliveryImpl("Summer Greens", "Pizza", "Jane Doe", "25/12/2016", 21);

            Assert.AreEqual("Summer Greens", delivery.Destination);
            Assert.AreEqual("Pizza", delivery.Description);
            Assert.AreEqual("Jane Doe", delivery.Recipient);
            Assert.AreEqual("25/12/2016", delivery.DueDate);
        }

        [TestMethod()]
        public void calculateTotalCostTest()
        {
            DeliveryImpl delivery = new DeliveryImpl();

            Assert.AreEqual((21 * 10.5), delivery.calculateTotalCost(21));
        }

        [TestMethod()]
        public void GetObjectDataTest()
        {

        }
    }
}