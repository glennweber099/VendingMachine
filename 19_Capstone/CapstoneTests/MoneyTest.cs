using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneTests
{
    [TestClass]
    public class MoneyTests
    {
        private class Money { }

        [DataTestMethod]
        [DataRow(, , DisplayName = "")]


        public void BalanceTest1(int submittedNumber, string expectedResult)
        {
            // Arrange
            // Create a new object
            Money product = new Money();

            // Act
            

            // Assert
            Assert.AreEqual(expectedResult, actualRN);
        }
    }
    
}
