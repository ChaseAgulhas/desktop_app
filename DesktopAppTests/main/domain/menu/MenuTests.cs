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
    public class MenuTests
    {
        [TestMethod()]
        public void MenuTest()
        {
            Menu menu = new Menu("Vegetarian");

            Assert.AreEqual("Vegetarian", menu.Category);
        }
    }
}