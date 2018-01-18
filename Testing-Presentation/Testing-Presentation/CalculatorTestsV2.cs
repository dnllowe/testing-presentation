using NUnit.Framework;

namespace Testing_Presentation
{
    [TestFixture]
    public class CalculatorTestsV2
    {
        Calculator _calculator;

        [TestFixtureSetUp]
        public void SetUp()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void TestAdd()
        {
            Assert.AreEqual(55, _calculator.Add(5, 50));
        }

        [Test]
        public void TestAdd2()
        {
            _calculator.Reset();
            Assert.AreEqual(50, _calculator.Add(50));
        }

        [Test]
        public void TestSubtract()
        {
            Assert.AreEqual(90, _calculator.Subtract(100, 10));
        }

        [Test]
        public void TestSubtract2()
        {
            _calculator.Reset();
            Assert.AreEqual(-10, _calculator.Subtract(10));
        }

        [Test]
        public void TestMultiply()
        {
            Assert.AreEqual(30, _calculator.Multiply(5, 6));
        }

        [Test]
        public void TestMultiply2()
        {
            _calculator.Reset();
            Assert.AreEqual(0, _calculator.Multiply(10));
        }

        [Test]
        public void TestDivide()
        {
            Assert.AreEqual(10, _calculator.Divide(50, 5));
        }

        [Test]
        public void TestDivide2()
        {
            _calculator.Reset();
            Assert.AreEqual(0, _calculator.Divide(10));
        }

        [Test]
        public void TestSquare()
        {
            Assert.AreEqual(9, _calculator.Square(3));
        }

        [Test]
        public void TestReset()
        {
            _calculator.Reset();
            Assert.AreEqual(0, _calculator.CurrentValue);
        }
    }
}