using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesktopApp.main.factories.driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.main.factories.driver.Tests
{
    [TestClass()]
    public class DriverFactoryTests
    {
        [TestMethod()]
        public void getDriverTest()
        {
            domain.Driver driver = DriverFactory.getDriver("Jim", "Crow", "555 456 1278", "driver@gmail.com", "Tyler2");

            Assert.AreEqual("Jim", driver.Name);
            Assert.AreEqual("Crow", driver.Surname);
            Assert.AreEqual("555 456 1278", driver.CellPhoneNumber);
            Assert.AreEqual("driver@gmail.com", driver.Email);
            Assert.AreEqual("Tyler2", driver.Password);
        }
    }
}