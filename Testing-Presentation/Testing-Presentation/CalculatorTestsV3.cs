using NUnit.Framework;

namespace Testing_Presentation
{
    [TestFixture]
    public class CalculatorTestsV3
    {
        Calculator _calculator;

        [TestFixtureSetUp]
        public void SetUp()
        {
            _calculator = new Calculator();
        }

        [TestCase]
        public void Add_TwoValuesGiven_ReturnsSumOfValues()
        {

        }

        public void Add_OneValueGiven_ReturnsSumOfCurrentValueAndArgument()
        {

        }

        public void Subtract_TwoValuesGiven_ReturnsDifferenceOfValues()
        {

        }

        public void Subtract_OneValueGiven_ReturnsDifferenceOfCurrentValueAndArgument()
        {

        }

        public void Multiply_TwoValuesGiven_ReturnsProductOfValues()
        {

        }

        public void Multiply_OneValueGiven_ReturnsProductOfCurrentValueAndArgument()
        {

        }

        public void Divide_TwoValuesGiven_ReturnsQuotientOfValues()
        {

        }

        public void Divide_OneValueGiven_ReturnsQuotientOfCurrentValueAndArgument()
        {

        }

        public void Reset_CalculatorHasPerformedOperationsBeforeReset_SetsCurrentValueToZero()
        {
            _calculator.Reset();
            Assert.AreEqual(_calculator.CurrentValue, 0);
        }
    }
}