using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problem1_Test {
    [TestClass]
    public class P1_Test {
        [TestMethod]
        public void EightyFiveIsNotDivisibleBy3() {
            //Arrange
            var numberToDivide = 85;

            //Act
            var isDivisible = Problem1.Program.IsDivisibleBy3(numberToDivide);

            //Assert
            Assert.AreEqual(false, isDivisible, "85 is not divisible by 3!!");
        }

        [TestMethod]
        public void SixtyThreeIsDivisibleBy3() {
            //Arrange
            var numberToDivide = 63;

            //Act
            var isDivisible = Problem1.Program.IsDivisibleBy3(numberToDivide);

            //Assert
            Assert.AreEqual(true, isDivisible, "63 is divisible by 3!!");
        }

        [TestMethod]
        public void NinetyThreeIsNotDivisibleBy5() {
            //Arrange
            var numberToDivide = 93;

            //Act
            var isDivisible = Problem1.Program.IsDivisibleBy5(numberToDivide);

            //Assert
            Assert.AreEqual(false, isDivisible, "93 is not divisible by 5!!");
        }

        [TestMethod]
        public void FiftyFiveIsDivisibleBy5() {
            //Arrange
            var numberToDivide = 55;

            //Act
            var isDivisible = Problem1.Program.IsDivisibleBy5(numberToDivide);

            //Assert
            Assert.AreEqual(true, isDivisible, "55 is not divisible by 5!!");
        }

        //[TestMethod]
        //public void SumOfFirst100IntegersShouldBe5050() {
        //    //Arrange
        //    var limit = 100;

        //    //Act
        //    var total = Problem1.Program.SumOfIntegers(limit);

        //    //Assert
        //    Assert.AreEqual(5050, total, "Sum of first 100 integers should be 5050!!");
        //}

        [TestMethod]
        public void SumOfMultiplesOf3Or5Below10_ShouldBe23() {
            //Arrange
            var limit = 9;

            //Act
            var total = Problem1.Program.SumOfIntegers(limit);

            //Assert
            Assert.AreEqual(23, total, "Sum of multiples of 3 or 5 below 10 must be 23!");
        }
    }
}
