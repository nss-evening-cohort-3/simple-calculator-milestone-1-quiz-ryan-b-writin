using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void TestLastFunction()
        {
            SpecialCommand spec = new SpecialCommand();
            string expected = "test command";
            spec.prevCommand.Push(expected);
            Assert.AreEqual(spec.GetPrevCommand(), expected);
        }
        [TestMethod]
        public void TestLastQfunction()
        {
            SpecialCommand spec = new SpecialCommand();
            string expected = "test command";
            spec.prevResult.Push(expected);
            Assert.AreEqual(spec.GetPrevResult(), expected);
        }
    }
}
