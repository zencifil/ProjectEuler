using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problem2_Test {

    [TestClass]
    public class P2_Test {

        [TestMethod]
        public void IsEven_Given10_ShouldReturnTrue() {
            //Arrange
            var given = 10;

            //Act
            var isEven = Problem2.Program.IsEven(given);

            //Assert
            Assert.IsTrue(isEven, "10 is even!!!");
        }

        //[TestMethod]
        //public void SumFibonacciSequenceForBelow100StartingFrom1_ShouldReturn231() {
        //    //Arrange
        //    var limit = 100;

        //    //Act
        //    var total = Problem2.Program.SumFibonacciSequence(limit);

        //    //Assert
        //    Assert.AreEqual(231, total);
        //}

        [TestMethod]
        public void SumFibonacciSeqEvenNumsForBelow100_ShouldReturn44() {
            //Arrange
            var limit = 100;

            //Act
            var total = Problem2.Program.SumFibonacciSequence(limit);

            //Assert
            Assert.AreEqual(44, total);
        }
    }
}
