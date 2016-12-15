using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesktopApp.main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.main.Tests
{
    [TestClass()]
    public class AddressTests
    {
        [TestMethod()]
        [Timeout(5000)]
        public void AddressTest()
        {
            Address address = new Address("123", "Rose Street", "Goodwood", "Cape Town", "7420");

            Assert.AreEqual("123", address.StreetNumber);
            Assert.AreEqual("Rose Street", address.StreetName);
            Assert.AreEqual("Goodwood", address.Suburb);
            Assert.AreEqual("Cape Town", address.City);
            Assert.AreEqual("7420", address.PostCode);
        }

        [TestMethod()]
        public void GetObjectDataTest()
        {
            
        }
    }
}