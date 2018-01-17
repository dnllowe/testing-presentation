using NUnit.Framework;

namespace Testing_Presentation
{
    [TestFixture]    
    public class CalculatorTestsV1
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
            Assert.AreEqual(_calculator.Add(2, 2), 4);

            _calculator.Reset();

            Assert.AreEqual(_calculator.Subtract(2, 2), 0);

            _calculator.Reset();

            Assert.AreEqual(_calculator.Multiply(2, 2), 4);

            _calculator.Reset();

            Assert.AreEqual(_calculator.Divide(2, 2), 1);
        }
    }
}
