using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords;

namespace NumbersToWordsTest
{
    [TestClass]
    public class NumbersTest
    {
        [TestMethod]
        public void ZeroToNineTests()
        {
            //-- Arrange
            CheckHelper checkZeroToNine = new CheckHelper();
            string expected = checkZeroToNine.ConvertZeroToNine(0);
            //-- Act
            string actual = "zero";

            //-- Assert
            Assert.AreEqual(expected, actual);

            //0 - 9 tests
            Assert.AreEqual(checkZeroToNine.ConvertZeroToNine(1), "one");
            Assert.AreEqual(checkZeroToNine.ConvertZeroToNine(2), "two");
            Assert.AreEqual(checkZeroToNine.ConvertZeroToNine(3), "three");
            Assert.AreEqual(checkZeroToNine.ConvertZeroToNine(4), "four");
            Assert.AreEqual(checkZeroToNine.ConvertZeroToNine(5), "five");
            Assert.AreEqual(checkZeroToNine.ConvertZeroToNine(6), "six");
            Assert.AreEqual(checkZeroToNine.ConvertZeroToNine(7), "seven");
            Assert.AreEqual(checkZeroToNine.ConvertZeroToNine(8), "eight");
            Assert.AreEqual(checkZeroToNine.ConvertZeroToNine(9), "nine");

        }
    }
}
