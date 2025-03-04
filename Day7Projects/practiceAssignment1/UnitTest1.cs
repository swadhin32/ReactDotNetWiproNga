namespace practiceAssignment1
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_ShouldReturnCorrectResult_WhenValidInputs()
        {
            var result = _calculator.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Subtract_ShouldReturnCorrectResult_WhenValidInputs()
        {
            var result = _calculator.Subtract(5, 3);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Multiply_ShouldReturnCorrectResult_WhenValidInputs()
        {
            var result = _calculator.Multiply(2, 3);
            Assert.AreEqual(6, result);
        }

        [Test]
        public void Divide_ShouldReturnCorrectResult_WhenValidInputs()
        {
            var result = _calculator.Divide(6, 3);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Divide_ShouldThrowDivideByZeroException_WhenDividingByZero()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(6, 0));
        }

        [Test]
        public void Add_ShouldReturnCorrectResult_WhenAddingZero()
        {
            var result = _calculator.Add(0, 3);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Subtract_ShouldReturnCorrectResult_WhenSubtractingZero()
        {
            var result = _calculator.Subtract(3, 0);
            Assert.AreEqual(3, result);
        }
    }

}