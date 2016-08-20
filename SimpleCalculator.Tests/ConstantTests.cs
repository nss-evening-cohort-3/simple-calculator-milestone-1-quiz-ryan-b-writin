using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ConstantTests
    {
        [TestMethod]
        public void EqualsOperationWorks()
        {
            Constants constant = new Constants();
            constant.EvaluateConstants("x", "2", "=");
            int expected = 2;
            Assert.AreEqual(constant.constants["x"], expected);

        }
        [TestMethod]
        public void EqualOperationFormat()
        {
            Constants constant = new Constants();
            constant.EvaluateConstants("2", "x", "=");
            Assert.IsTrue(constant.exceptionCaught);
        }
        [TestMethod]
        public void SetAConstantOnlyOnce()
        {
            Constants constant = new Constants();
            constant.EvaluateConstants("w", "2", "=");
            constant.EvaluateConstants("w", "3", "=");
            Assert.IsTrue(constant.exceptionCaught);
        }
        [TestMethod]
        public void FirstDigitIsAConstant()
        {
            Constants constant = new Constants();
            constant.EvaluateConstants("r", "2", "=");
            constant.EvaluateConstants("r", "3", "+");
            int expected = 2;
            //checks that the method outputs the correct number in place of the letter R
            Assert.AreEqual(constant.firstTerm, expected);
        }
        [TestMethod]
        public void SecondDigitIsAConstant()
        {
            Constants constant = new Constants();
            constant.EvaluateConstants("t", "2", "=");
            constant.EvaluateConstants("3", "t", "+");
            int expected = 2;
            Assert.AreEqual(constant.secondTerm, expected);
        }
        [TestMethod]
        public void ConstantEqualsAnInvalidConstant()
        {
            Constants constant = new Constants();
            constant.EvaluateConstants("x", "y", "=");
            Assert.IsTrue(constant.exceptionCaught);
        }
        [TestMethod]
        public void ConstantEqualsAValidConstant()
        {
            Constants constant = new Constants();
            constant.EvaluateConstants("q", "2", "=");
            constant.EvaluateConstants("b", "q", "=");
            int expected = 2;
            Assert.AreEqual(constant.constants["b"], expected);
        }
        [TestMethod]
        public void InvalidConstantIsFirstTerm()
        {
            Constants constant = new Constants();
            constant.EvaluateConstants("x", "2", "+");
            Assert.IsTrue(constant.exceptionCaught);
        }
        [TestMethod]
        public void InvalidConstantIsSecondTerm()
        {
            Constants constant = new Constants();
            constant.EvaluateConstants("2", "x", "+");
            Assert.IsTrue(constant.exceptionCaught);
        }
        [TestMethod]
        public void ConstantsAreCaseInsensitive()
        {
            Constants constant = new Constants();
            constant.EvaluateConstants("M", "2", "=");
            int expected = 2;
            Assert.AreEqual(constant.constants["m"], expected);
        }
    }
}
