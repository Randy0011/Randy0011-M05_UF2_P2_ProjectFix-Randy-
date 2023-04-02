using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DayOfTheWeek.Tests
{
    [TestClass]
    public class DayOfTheWeek_Tests
    {
        [TestMethod]
        public void DayOfTheWeek_Test()
        {
            //Arrange
            DateTime time = DateTime.Now;
            int result = 0;
            int resultOK = (int)time.DayOfWeek;
            //Act
            result = DayOfTheWeek.Program.DayOfTheWeek(time.Year, time.Month, time.Day);
            //Assert
            Assert.AreEqual(resultOK, result);
        }
    }
}
