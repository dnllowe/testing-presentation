using NUnit.Framework;

namespace Testing_Presentation
{
    [TestFixture]
    public class CalculatorTestsV3
    {
        [Test]
        public void Add_TwoValuesGiven_ReturnsSumOfValues()
        {
            // Assemble
            Calculator calculator = new Calculator();

            // Act
            var actual = calculator.Add(5, 50);

            // Assert
            Assert.AreEqual(55, actual);
        }

        [Test]
        public void Add_OneValueGiven_ReturnsSumOfCurrentValueAndArgument()
        {
            // Assemble
            Calculator calculator = new Calculator();
            var expected = calculator.CurrentValue + 50;

            // Act
            var actual = calculator.Add(50);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Subtract_TwoValuesGiven_ReturnsDifferenceOfValues()
        {
            // Assemble
            Calculator calculator = new Calculator();

            // Act
            var actual = calculator.Subtract(100, 10);

            // Assert
            Assert.AreEqual(90, actual);
        }

        [Test]
        public void Subtract_OneValueGiven_ReturnsDifferenceOfCurrentValueAndArgument()
        {
            // Assemble
            Calculator calculator = new Calculator();
            var expected = calculator.CurrentValue - 10;

            // Act
            var actual = calculator.Subtract(10);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Multiply_TwoValuesGiven_ReturnsProductOfValues()
        {
            // Assemble
            Calculator calculator = new Calculator();

            // Act
            var actual = calculator.Multiply(5, 6);

            // Assert
            Assert.AreEqual(30, actual);
        }

        [Test]
        public void Multiply_OneValueGiven_ReturnsProductOfCurrentValueAndArgument()
        {
            // Assemble
            Calculator calculator = new Calculator();
            var expected = calculator.CurrentValue * 10;

            // Act
            var actual = calculator.Multiply(10);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Divide_TwoValuesGiven_ReturnsQuotientOfValues()
        {
            // Assemble
            Calculator calculator = new Calculator();

            // Act
            var actual = calculator.Divide(50, 5);

            // Assert
            Assert.AreEqual(10, actual);
        }

        [Test]
        public void Divide_OneValueGiven_ReturnsQuotientOfCurrentValueAndArgument()
        {
            // Assemble
            Calculator calculator = new Calculator();
            var expected = calculator.CurrentValue / 10;

            // Act
            var actual = calculator.Divide(10);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Square()
        {
            // Assemble
            Calculator calculator = new Calculator();

            // Act
            var actual = calculator.Square(3);

            // Assert
            Assert.AreEqual(9, actual);
        }

        [Test]
        public void Reset_CalculatorHasPerformedOperationsBeforeReset_SetsCurrentValueToZero()
        {
            // Assemble
            Calculator calculator = new Calculator();
            calculator.Add(1);
            calculator.Add(1);
            calculator.Add(1);

            var expected = 0;

            // Act
            calculator.Reset();

            // Assert
            Assert.AreEqual(expected, calculator.CurrentValue);
        }
    }
}

