using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problem3_Test {

    [TestClass]
    public class P3_Test {

        [TestMethod]
        public void IsPrime_Given29_ShouldReturnTrue() {
            //Arrange
            var given = 29;

            //Act
            var isPrime = Problem3.Program.IsPrime(given);

            //Assert
            Assert.IsTrue(isPrime);
        }

        [TestMethod]
        public void LargestPrimeFactor_Given13195_ShouldReturn29() {
            //Arrange
            var given = 13195;

            //Act
            var largestPrimeFactor = Problem3.Program.LargestPrimeFactor(given);

            //Assert
            Assert.AreEqual(29, largestPrimeFactor);
        }
    }
}
