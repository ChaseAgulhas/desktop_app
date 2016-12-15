using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesktopApp.main.factories.customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.main.factories.customer.Tests
{
    [TestClass()]
    public class CustomerFactoryTests
    {
        [TestMethod()]
        public void getCustomerTest()
        {
            domain.Customer customer = CustomerFactory.getCustomer("John", "Doe", "789 456 123");

            Assert.AreEqual("John", customer.Name);
            Assert.AreEqual("Doe", customer.Surname);
            Assert.AreEqual("789 456 123", customer.PhoneNumber);
        }
    }
}