using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class EvaluationTests
    {
        [TestMethod]
        public void AdditionTest()
        {
            Evaluation evaluation = new Evaluation(2, 2, "+");
            int expected = 4;
            Assert.AreEqual(evaluation.result, expected);
        }
        [TestMethod]
        public void SubtractionTest()
        {
            Evaluation evaluation = new Evaluation(8, 2, "-");
            int expected = 6;
            Assert.AreEqual(evaluation.result, expected);
        }
        [TestMethod]
        public void MultiplicationTest()
        {
            Evaluation evaluation = new Evaluation(5, 3, "*");
            int expected = 15;
            Assert.AreEqual(evaluation.result, expected);
        }
        [TestMethod]
        public void DivisionTest()
        {
            Evaluation evaluation = new Evaluation(8, 4, "/");
            int expected = 2;
            Assert.AreEqual(evaluation.result, expected);
        }
        [TestMethod]
        public void ModulusTest()
        {
            Evaluation evaluation = new Evaluation(10, 3, "%");
            int expected = 1;
            Assert.AreEqual(evaluation.result, expected);
        }

    }
}
