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
    public class LoginTests
    {
        [TestMethod()]
        public void LoginTest()
        {
            Login login = new Login("Username", "Password");

            Assert.AreEqual("Username", login.Username);
            Assert.AreEqual("Password", login.Password);
        }
    }
}