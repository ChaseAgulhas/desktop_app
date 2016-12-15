using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesktopApp.main.factories.foodItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.main.factories.foodItem.Tests
{
    [TestClass()]
    public class FoodItemFactoryTests
    {
        [TestMethod()]
        public void getFoodItemTest()
        {
            domain.FoodItem foodItem = FoodItemFactory.getFoodItem("Chicken gatsby", 95, 20);

            Assert.AreEqual("Chicken gatsby", foodItem.Name);
            Assert.AreEqual(95, foodItem.Price);
            Assert.AreEqual(20, foodItem.AmountAvailable);
        }
    }
}