using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesktopApp.main.factories.address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.main.factories.address.Tests
{
    [TestClass()]
    public class AddressFactoryTests
    {
        [TestMethod()]
        public void getAddressTest()
        {
            Address adress = AddressFactory.getAddress("123", "Rose Street", "Goodwood", "Cape Town", "7420");

            Assert.AreEqual("123", adress.StreetNumber);
            Assert.AreEqual("Rose Street", adress.StreetName);
            Assert.AreEqual("Goodwood", adress.Suburb);
            Assert.AreEqual("Cape Town", adress.City);
            Assert.AreEqual("7420", adress.PostCode);
        }
    }
}