using NUnit.Framework;
using MyCalculator;

namespace Tests
{
    public class Tests
    {
        Calculator _calc;
        [SetUp]
        public void Setup()
        {
            _calc = new Calculator();
        }

        [Test]
        public void Given_Two_Number_Perform_Addition()
        {
            int result = _calc.Add(1, 2);
            Assert.AreEqual(3, result, "Value are different");
        }

        [Test]
        public void FailingTest()
        {
            Assert.Fail();
        }

        [Test]
        [Category("Samples")]
        public void IgnoreTest()
        {
            Assert.Ignore();
        }
    }
}