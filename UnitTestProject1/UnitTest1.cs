using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sessia2;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        
        
        [TestMethod]
        public void GetNextMarkAfterInRange1()
        {
            string exception = "A006AA152";
            string prevMark = "A005AA152";
            string rangeStart = "A001AA152";
            string rangeEnd = "A800AB152";
            string actual = REG_MARK_LIB.GetNextMarkAfterInRange(prevMark, rangeStart, rangeEnd);
            Assert.IsTrue(exception == actual);
        }
        
        [TestMethod]
        public void GetNextMarkAfterInRange2()
        {
            string prevMark = "A005AA152";
            string rangeStart = "A001AA152";
            string rangeEnd = "A800AB152";
            string actual = REG_MARK_LIB.GetNextMarkAfterInRange(prevMark, rangeStart, rangeEnd);
            Assert.IsInstanceOfType(actual, typeof(string));
        }
       
        [TestMethod]
        public void CheckMark_CorrectlyType3()
        {
            string mark = "A000AA152";
            bool actual = REG_MARK_LIB.CheckMark(mark);
            Assert.IsInstanceOfType(actual, typeof(bool));
        }

        [TestMethod]
        public void GetNextMarkAfter_Border5()
        {
            string exception = "error";
            string mark = "X999XX152";
            string actual = REG_MARK_LIB.GetNextMarkAfter(mark);
            Assert.IsTrue(exception == actual);
        }
   
        [TestMethod]
        public void GetNextMarkAfterInRange4()
        {
            string exception = "out of stock";
            string prevMark = "A005AA777";
            string rangeStart = "A001AA155";
            string rangeEnd = "A800AB155";
            string actual = REG_MARK_LIB.GetNextMarkAfterInRange(prevMark, rangeStart, rangeEnd);
            Assert.AreEqual(exception, actual);
        }

        [TestMethod]
        public void GetNextMarkAfterInRange6()
        {
            string exception = "out of stock";
            string prevMark = "A990AB152";
            string rangeStart = "A001AA152";
            string rangeEnd = "A800AB152";
            string actual = REG_MARK_LIB.GetNextMarkAfterInRange(prevMark, rangeStart, rangeEnd);
            Assert.IsTrue(exception == actual);
        }
        [TestMethod]
        public void CheckMark_NotCorrectlyRegion7()
        {
            bool exception = false;
            string mark = "X345AT000";
            bool actual = REG_MARK_LIB.CheckMark(mark);
            Assert.AreEqual(exception, actual);
        }
        [TestMethod]
        public void GetCombinationsCountInRange8()
        {
            int exception = 1009;
            string mark1 = "A001AA152";
            string mark2 = "A010AB152";
            int actual = REG_MARK_LIB.GetCombinationsCountInRange(mark1, mark2);
            Assert.AreEqual(exception, actual);
        }

        [TestMethod]
        public void GetCombinationsCountInRange10()
        {
            int exception = 150;
            string mark1 = "A001AA152";
            string mark2 = "A010AA152";
            int actual = REG_MARK_LIB.GetCombinationsCountInRange(mark1, mark2);
            Assert.IsTrue(exception != actual);
        }
        
    }
}
