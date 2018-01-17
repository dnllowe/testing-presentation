using NUnit.Framework;

namespace Testing_Presentation
{
    [TestFixture]
    public class TestCalculatorV2
    {
        Calculator _calculator;

        [TestFixtureSetUp]
        public void SetUp()
        {
            _calculator = new Calculator();
        }

        [TestCase]
        public void TestAdd()
        {
            Assert.AreEqual(_calculator.Add(2, 2), 4);
        }

        public void TestAdd2()
        {
            Assert.AreEqual(_calculator.Add(2), 4);
        }

        public void TestSubtract()
        {
            Assert.AreEqual(_calculator.Subtract(2, 2), 0);
        }

        public void TestSubtract2()
        {
            Assert.AreEqual(_calculator.Subtract(2), 0);
        }

        public void TestMultiply()
        {
            Assert.AreEqual(_calculator.Multiply(2, 2), 4);
        }

        public void TestMultiply2()
        {
            Assert.AreEqual(_calculator.Multiply(2), 4);
        }

        public void TestDivide()
        {
            Assert.AreEqual(_calculator.Divide(2, 2), 1);
        }

        public void TestDivide2()
        {
            Assert.AreEqual(_calculator.Divide(2), 1);
        }

        public void TestReset()
        {
            _calculator.Reset();
            Assert.AreEqual(_calculator.CurrentValue, 0);
        }
    }
}