using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Factorial.UnitTests 
{
    [TestClass]
    public class TestFactorial
    {
        [TestMethod]
        public void FactorialReturns1ForArgumrnt0()
        {
            var result = Math.Factorial(0);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void FactorialReturns1ForArgumrnt1()
        {
            var result = Math.Factorial(1);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void FactorialReturns2ForArgumrnt2()
        {
            var result = Math.Factorial(2);
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void FactorialReturns4ForArgumrnt4()
        {
            var result = Math.Factorial(4);
            Assert.AreEqual(24, result);
        }

    }
}
