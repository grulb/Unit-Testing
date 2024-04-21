using Microsoft.VisualStudio.TestTools.UnitTesting;
using calculatorProgram;

namespace calculatorTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PlusTest()
        {
            int result = Calculator.Plus(5, 3);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void MinusTest()
        {
            int result = Calculator.Minus(10, 4);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void MultiplyTest()
        {
            int result = Calculator.Multiply(6, 7);
            Assert.AreEqual(42, result);
        }

        [TestMethod]
        public void DivideTest()
        {
            int result = Calculator.Divide(20, 5);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void DivisionByZeroTest()
        {
            Assert.ThrowsException<DivideByZeroException>(() => Calculator.Divide(10, 0));
        }
    }
}