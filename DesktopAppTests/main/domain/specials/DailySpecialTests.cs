using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesktopApp.main.domain.specials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.main.domain.specials.Tests
{
    [TestClass()]
    public class DailySpecialTests
    {
        [TestMethod()]
        public void DailySpecialTest()
        {
            DailySpecial dailySpecial = new DailySpecial("Monday only", "R260", "Monday");

            Assert.AreEqual("Monday only", dailySpecial.Name);
            Assert.AreEqual("R260", dailySpecial.Price);
            Assert.AreEqual("Monday", dailySpecial.DayOfSpecial);
        }
    }
}