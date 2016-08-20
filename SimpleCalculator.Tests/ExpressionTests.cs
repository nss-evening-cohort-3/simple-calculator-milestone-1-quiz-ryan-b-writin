using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ExpressionTests
    {
        [TestMethod]
        public void CaptureTheFirstTerm()
        {
            string input = "326456 + 4232";
            string expected = "326456";
            Expression newExpression = new Expression(input);
            Assert.AreEqual(newExpression.firstTerm, expected);
        }
        [TestMethod]
        public void CaptureTheSecondTerm()
        {
            string input = "23423 + 32433";
            string expected = "32433";
            Expression newExpression = new Expression(input);
            Assert.AreEqual(newExpression.secondTerm, expected);
        }
        [TestMethod]
        public void CaptureTheOperator()
        {
            string input = "45236 / 34563";
            string expected = "/";
            Expression newExpression = new Expression(input);
            Assert.AreEqual(newExpression._operator, expected);

        }
        [TestMethod]
        public void recognizeIncorrectInput()
        {
            Expression newExpression = new Expression("+2");
            Assert.IsTrue(newExpression.exceptionCaught);
        }
    }
}
