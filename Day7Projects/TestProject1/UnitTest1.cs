using ArthematicOpsAndOther;
namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        private Calculate _calculate;

        [SetUp]
        public void Setup()
        {
            // Initialize the Calculate object before each test
            _calculate = new Calculate();
        }

        [Test]
        public void Addition()
        {
        
            
            int actual = _calculate.Addition(20, 30);
            int expected = 50;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Subtraction()
        {
            int actual = _calculate.Subtract(30, 20);
            int expected = 10;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Multiplication()
        {
            int actual = _calculate.Multiplication(20, 30);
            int expected = 600;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DivideWithException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculate.Divide(12,0));
        }

        [Test]
        public void Divide()
        {
            int actual = _calculate.Divide(12, 4);
            int expected = 3;
            Assert.AreEqual(expected, actual);
        }

        //[TestCase("", 0)] // Empty password
        //[TestCase("12345", 1)] // Digits only
        //[TestCase("password123", 2)] // Lowercase + digits
       // [TestCase("Password123", 3)] // Uppercase + lowercase + digits
       // [TestCase("Password@123",4)] // Special char + uppercase + lowercase + digits
        public void GetPasswordStrength_ShouldReturnExpectedStrength(string password, int expectedStrength)
        {
            int result = _calculate.GetPasswordStrength(password);
            Assert.AreEqual(expectedStrength, result);
        }

        [TearDown]
        public void TearDown()
        {
            // Clean up after each test
            _calculate = null;
        }
    }



}