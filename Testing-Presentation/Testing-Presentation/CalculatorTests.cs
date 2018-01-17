using NUnit.Framework;

namespace Testing_Presentation
{
    [TestFixture]    
    public class CalculatorTests
    {
        Calculator _calculator;

        [TestFixtureSetUp]
        public void SetUp()
        {
            _calculator = new Calculator();
        }

        [TestCase]
        public void TestCalculator()
        {
            Assert.AreEqual(4, _calculator.Add(2, 2));
            _calculator.Reset();
            Assert.AreEqual(0, _calculator.Subtract(2, 2));
            _calculator.Reset();
            Assert.AreEqual(4, _calculator.Multiply(2, 2));
            _calculator.Reset();
            Assert.AreEqual(1, _calculator.Divide(2, 2));
        }
    }
}
