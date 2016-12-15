using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesktopApp.main.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.main.domain.Tests
{
    [TestClass()]
    public class CustomerTests
    {
        [TestMethod()]
        public void CustomerTest()
        {
            Customer customer = new Customer("John", "Doe", "789 456 123");

            Assert.AreEqual("John", customer.Name);
            Assert.AreEqual("Doe", customer.Surname);
            Assert.AreEqual("789 456 123", customer.PhoneNumber);

        }

        [TestMethod()]
        public void GetObjectDataTest()
        {

        }
    }
}