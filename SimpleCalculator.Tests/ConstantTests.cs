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
            constant.EvaluateConstants("x", "2", "=");
            constant.EvaluateConstants("x", "3", "=");
            Assert.IsTrue(constant.exceptionCaught);
        }
        [TestMethod]
        public void FirstDigitIsAConstant()
        {
            Constants constant = new Constants();
            constant.EvaluateConstants("x", "2", "=");
            constant.EvaluateConstants("x", "3", "+");
            int expected = 2;
            Assert.AreEqual(constant.firstTerm, expected);
        }
        [TestMethod]
        public void SecondDigitIsAConstant()
        {
            Constants constant = new Constants();
            constant.EvaluateConstants("x", "2", "=");
            constant.EvaluateConstants("3", "x", "+");
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
            constant.EvaluateConstants("x", "2", "=");
            constant.EvaluateConstants("y", "x", "=");
            int expected = 2;
            Assert.AreEqual(constant.constants["y"], expected);
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
    }
}
