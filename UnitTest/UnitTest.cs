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
        public void IncorrectFamilyIndex()
        {
            Assert.AreEqual("Error: Incorrect family index!", BabySitterObj.CalculateTotalPay('X', 0, 0));
        }

        [TestMethod]
        public void InvalidStartTime()
        {
            Assert.AreEqual("Error: Invalid start or end hour!", BabySitterObj.CalculateTotalPay('A', 13, 4));
        }

        [TestMethod]
        public void InvalidEndTime()
        {
            Assert.AreEqual("Error: Invalid start or end hour!", BabySitterObj.CalculateTotalPay('A', 5, 17));
        }

        [TestMethod]
        public void StartTimeIsAfterEndTime()
        {
            Assert.AreEqual("Error: Invalid start or end hour!", BabySitterObj.CalculateTotalPay('A', 1, 5));
        }

        [TestMethod]
        public void WorkedForFamilyA2HoursFrom5PMto7PM()
        {
            Assert.AreEqual("30.00 $", BabySitterObj.CalculateTotalPay('A', 5, 7));
        }

        [TestMethod]
        public void WorkedForFamilyA4HoursFrom12AMto4AM()
        {
            Assert.AreEqual("80.00 $", BabySitterObj.CalculateTotalPay('A', 12, 4));
        }

        [TestMethod]
        public void WorkedForFamilyA4HoursFrom9PMto1AM()
        {
            Assert.AreEqual("70.00 $", BabySitterObj.CalculateTotalPay('A', 9, 1));
        }

        [TestMethod]
        public void WorkedForFamilyB5HoursFrom5PMTo10PM()
        {
            Assert.AreEqual("60.00 $", BabySitterObj.CalculateTotalPay('B', 5, 10));
        }

        [TestMethod]
        public void WorkedForFamilyB2HoursFrom10PMTo12AM()
        {
            Assert.AreEqual("16.00 $", BabySitterObj.CalculateTotalPay('B', 10, 12));
        }

        [TestMethod]
        public void WorkedForFamilyB4HoursFrom12AMTo4AM()
        {
            Assert.AreEqual("64.00 $", BabySitterObj.CalculateTotalPay('B', 12, 4));
        }

        [TestMethod]
        public void WorkedForFamilyB4HoursFrom9PMTo1AM()
        {
            Assert.AreEqual("44.00 $", BabySitterObj.CalculateTotalPay('B', 9, 1));
        }

        [TestMethod]
        public void WorkedForFamilyC4HoursFrom7PMto11PM()
        {
            Assert.AreEqual("72.00 $", BabySitterObj.CalculateTotalPay('C', 7, 11));
        }
    }
}
