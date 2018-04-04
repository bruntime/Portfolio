using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EsperantoNumbers;

namespace EsperantoNumbersTest
{
    [TestClass]
    public class NumbersTest
    {
        [TestMethod]
        public void UserInputValid()
        {
            //test that user input is valid

            //-- Arrange

            //-- Act

            //-- Assert
        }
        public void NumbersToWordsValid()
        {
            //test that an actual value returns as expected value
            
            //-- Arrange
            var testInstance = new NumbersDictionary();

            //-- Act
            testInstance.NumbersToWords();

            //-- Assert

        }
    }
}
