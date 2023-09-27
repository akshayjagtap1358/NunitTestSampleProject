using NUnit.Framework;
using NUnitIntegrateWithJenkinsDummyProject;

namespace NUnitTests
{
    [TestFixture]
    public class TestClass
    {
        Form1 form1;

        [SetUp]
        public void Setup()
        {
            form1 = new Form1(); 

        }

        [Test]
        public void TestAddFunction()
        {
            int result = form1.Add(10, 20);
            Assert.AreEqual(30, result);
        }

        [Test]
        public void TestSubtractFunction()
        {
            int result = form1.Subtract(20, 20);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void TestMultiplyFunction()
        {
            int result = form1.Multiply(10, 20);
            Assert.AreEqual(200, result);
        }

        [Test]
        public void TestDivideFunction()
        {
            int result = form1.Divide(20, 10);
            Assert.AreEqual(2, result);
        }
    }
}
