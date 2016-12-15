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
    public class DriverTests
    {
        [TestMethod()]
        public void DriverTest()
        {
            Driver driver = new Driver("Jim", "Crow", "555 456 1278", "driver@gmail.com", "Tyler2");

            Assert.AreEqual("Jim", driver.Name);
            Assert.AreEqual("Crow", driver.Surname);
            Assert.AreEqual("555 456 1278", driver.CellPhoneNumber);
            Assert.AreEqual("driver@gmail.com", driver.Email);
            Assert.AreEqual("Tyler2", driver.Password);

        }

        [TestMethod()]
        public void GetObjectDataTest()
        {

        }
    }
}