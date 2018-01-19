using NUnit.Framework;
using System;

namespace Testing_Presentation
{
    [TestFixture]
    public class AttributesTests
    {
        [TestFixtureSetUp]
        public void RunsOnceBeforeTestingStart()
        {
            Console.WriteLine("I ran ONCE BEFORE testing STARTED");
        }

        [TestFixtureTearDown]
        public void RunsOnceAfterTestingEnds()
        {
            Console.WriteLine("I ran ONCE AFTER testing ENDED");
        }

        [SetUp]
        public void RunsBeforeEveryTest()
        {
            Console.WriteLine("I ran BEFORE EVERY test");
        }

        [TearDown]
        public void RunsAfterEveryTest()
        {
            Console.WriteLine("I ran AFTER EVERY test");
        }

        [Test]
        public void Test_1() { }

        [Test]
        public void Test_2() { }

        [Test]
        public void Test_3() { }
    }
}