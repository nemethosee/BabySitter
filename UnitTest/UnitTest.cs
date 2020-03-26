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
            Assert.AreEqual("0.00 $", BabySitterObj.CalculateTotalPay("A", 0, 1));
        }

        [TestMethod]
        public void IncorrectFamilyIndex()
        {
            Assert.AreEqual("Error: Incorrect family index!", BabySitterObj.CalculateTotalPay("X", 0, 0));
        }

        [TestMethod]
        public void InvalidStartTime()
        {
            Assert.AreEqual("Error: Invalid start or end hour!", BabySitterObj.CalculateTotalPay("A", 12, 0));
        }

        [TestMethod]
        public void InvalidEndTime()
        {
            Assert.AreEqual("Error: Invalid start or end hour!", BabySitterObj.CalculateTotalPay("A", 0, 12));
        }

        [TestMethod]
        public void StartTimeIsAfterEndTime()
        {
            Assert.AreEqual("Error: Invalid start or end hour!", BabySitterObj.CalculateTotalPay("A", 10, 9));
        }

    }
}
