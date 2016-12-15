using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesktopApp.main.factories.menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.main.factories.menu.Tests
{
    [TestClass()]
    public class MenuFactoryTests
    {
        [TestMethod()]
        public void getMenuTest()
        {
            domain.Menu menu = MenuFactory.getMenu("Vegetarian");

            Assert.AreEqual("Vegetarian", menu.Category);
        }
    }
}