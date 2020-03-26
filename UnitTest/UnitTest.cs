using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Babysitter;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        BabySitter BabySitterObj;

        [TestInitialize]
        public void InitializeTests()
        {
            BabySitterObj = new BabySitter();
        }

        [TestMethod]
        public void NoHoursWorkedNoPayment()
        {
            Assert.AreEqual("0.00 $", BabySitterObj.CalculateTotalPay("A", 0, 0));
        }

        [TestMethod]
        public void IncorrectFamilyIndex()
        {
            Assert.AreEqual("Error: Incorrect family index!", BabySitterObj.CalculateTotalPay("X", 0, 0));
        }
    }
}
