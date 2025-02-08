namespace PositivenegativeEdgeTestcase
{
    public class Calculator
    {
        public int Divide(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("Denominator cannot be zero.");
            }
            return numerator / denominator;
        }
    }



    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        // Positive test case: normal division
        [Test]
        public void Divide_ShouldReturnCorrectResult_WhenInputsAreValid()
        {
            var result = _calculator.Divide(10,2);
            Assert.AreEqual(5, result);
        }

        // Negative test case: dividing by zero
        [Test]
        public void Divide_ShouldThrowDivideByZeroException_WhenDenominatorIsZero()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10,0));// here if u put 10,2 it will fail //why it will take unproepr innput only as it is negative test case 
        }

        // Edge case: division resulting in a fraction (rounding down)
        [Test]
        public void Divide_ShouldRoundDown_WhenResultIsFraction()
        {
            var result = _calculator.Divide(7,5);  // in calculator it will give 1.4 rounded to 1 which is matching expected 
            Assert.AreEqual(1, result); // Integer division, rounds down
        }

        // Edge case: very large numbers
        [Test]
        public void Divide_ShouldHandleLargeNumbers()
        {
            var result = _calculator.Divide(int.MaxValue, 1);
            Assert.AreEqual(int.MaxValue, result);
        }
    }
}