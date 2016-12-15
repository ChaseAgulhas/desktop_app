using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesktopApp.main.factories.delivery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.main.factories.delivery.Tests
{
    [TestClass()]
    public class DeliveryFactoryTests
    {
        [TestMethod()]
        public void getDeliveryTest()
        {
            domain.delivery.impl.DeliveryImpl delivery = DeliveryFactory.getDelivery("Summer Greens", "Pizza", "Jane Doe", "25/12/2016", 21);

            Assert.AreEqual("Summer Greens", delivery.Destination);
            Assert.AreEqual("Pizza", delivery.Description);
            Assert.AreEqual("Jane Doe", delivery.Recipient);
            Assert.AreEqual("25/12/2016", delivery.DueDate);
        }
    }
}