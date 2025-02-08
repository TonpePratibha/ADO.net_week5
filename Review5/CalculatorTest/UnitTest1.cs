using Review5;

namespace CalculatorTest
{
    public class Tests
    {
        private Calculator cal;

        [SetUp]
        public void Setup()
        {
            cal = new Calculator();
        }

        [Test]
        public void Add()
        {
            int a = 4;
            int b = 5;
            int expected = 9;
            int actual = cal.Add(a, b);

            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void subtract()
        {
            int a = 5;
            int b = 4;
            int expected = 1;
            int actual = cal.Subtract(a, b);
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void multiply()
        {
            int a = 5;
            int b = 4;
            int expected = 20;
            int actual = cal.Multiply(a, b);
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void divide()
        {
            int a = 5;
            int b = 4;
            int expected = 1;
            int actual = cal.Divide(a, b);
            Assert.AreEqual(actual, expected);
        }
    }
}