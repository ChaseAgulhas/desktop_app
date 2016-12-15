using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesktopApp.main.factories.login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.main.factories.login.Tests
{
    [TestClass()]
    public class LoginFactoryTests
    {
        [TestMethod()]
        public void getLoginTest()
        {
            domain.Login login = LoginFactory.getLogin("Username", "Password");

            Assert.AreEqual("Username", login.Username);
            Assert.AreEqual("Password", login.Password);
        }
    }
}