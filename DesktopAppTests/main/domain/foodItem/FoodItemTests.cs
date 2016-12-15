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
    public class FoodItemTests
    {
        [TestMethod()]
        public void FoodItemTest()
        {
            FoodItem foodItem = new FoodItem("Chicken gatsby", 95, 20);

            Assert.AreEqual("Chicken gatsby", foodItem.Name);
            Assert.AreEqual(95, foodItem.Price);
            Assert.AreEqual(20, foodItem.AmountAvailable);
        }

        [TestMethod()]
        public void GetObjectDataTest()
        {
            
        }
    }
}