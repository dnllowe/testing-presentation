using NUnit.Framework;
using System.Collections;

namespace Testing_Presentation
{
    [TestFixture]
    public class TestCasesExample
    {
        [TestCase(5, 5, 10)]
        public void Add_TwoValuesGiven_ReturnsSumOfArguments(int num1, int num2, int result)
        {
           Assert.AreEqual(result, num1 + num2);
        }

        [TestCase(10, 5, ExpectedResult = 5)]
        [TestCase(15, 5, ExpectedResult = 10)]
        [TestCase(20, 5, ExpectedResult = 15)]
        public int Subtract_TwoValuesGiven_ReturnsDifferenceOfArguments(int num1, int num2)
        {
            return num1 - num2;
        }

        [Test, TestCaseSource(typeof(MultiplicationTableTestsData), "TestCases")]
        public int Multiply_TwoValuesGiven_ReturnsProductOfArguments(int num1, int num2)
        {
            return num1 * num2;
        }
    }

    public class MultiplicationTableTestsData
    {
        public static IEnumerable TestCases()
        {
            yield return new TestCaseData(1, 1).Returns(1);
            yield return new TestCaseData(1, 2).Returns(2);
            yield return new TestCaseData(1, 3).Returns(3);
            yield return new TestCaseData(1, 4).Returns(4);
            yield return new TestCaseData(1, 5).Returns(5);
            yield return new TestCaseData(1, 6).Returns(6);
            yield return new TestCaseData(1, 7).Returns(7);
            yield return new TestCaseData(1, 8).Returns(8);
            yield return new TestCaseData(1, 9).Returns(9);
            yield return new TestCaseData(1, 10).Returns(10);

            yield return new TestCaseData(2, 1).Returns(2);
            yield return new TestCaseData(2, 2).Returns(4);
            yield return new TestCaseData(2, 3).Returns(6);
            yield return new TestCaseData(2, 4).Returns(8);
            yield return new TestCaseData(2, 5).Returns(10);
            yield return new TestCaseData(2, 6).Returns(12);
            yield return new TestCaseData(2, 7).Returns(14);
            yield return new TestCaseData(2, 8).Returns(16);
            yield return new TestCaseData(2, 9).Returns(18);
            yield return new TestCaseData(2, 10).Returns(20);

            yield return new TestCaseData(3, 1).Returns(3);
            yield return new TestCaseData(3, 2).Returns(6);
            yield return new TestCaseData(3, 3).Returns(9);
            yield return new TestCaseData(3, 4).Returns(12);
            yield return new TestCaseData(3, 5).Returns(15);
            yield return new TestCaseData(3, 6).Returns(18);
            yield return new TestCaseData(3, 7).Returns(21);
            yield return new TestCaseData(3, 8).Returns(24);
            yield return new TestCaseData(3, 9).Returns(27);
            yield return new TestCaseData(3, 10).Returns(30);

            yield return new TestCaseData(4, 1).Returns(4);
            yield return new TestCaseData(4, 2).Returns(8);
            yield return new TestCaseData(4, 3).Returns(12);
            yield return new TestCaseData(4, 4).Returns(16);
            yield return new TestCaseData(4, 5).Returns(20);
            yield return new TestCaseData(4, 6).Returns(24);
            yield return new TestCaseData(4, 7).Returns(28);
            yield return new TestCaseData(4, 8).Returns(32);
            yield return new TestCaseData(4, 9).Returns(36);
            yield return new TestCaseData(4, 10).Returns(40);

            yield return new TestCaseData(5, 1).Returns(5);
            yield return new TestCaseData(5, 2).Returns(10);
            yield return new TestCaseData(5, 3).Returns(15);
            yield return new TestCaseData(5, 4).Returns(20);
            yield return new TestCaseData(5, 5).Returns(25);
            yield return new TestCaseData(5, 6).Returns(30);
            yield return new TestCaseData(5, 7).Returns(35);
            yield return new TestCaseData(5, 8).Returns(40);
            yield return new TestCaseData(5, 9).Returns(45);
            yield return new TestCaseData(5, 10).Returns(50);
        }
    }
}

