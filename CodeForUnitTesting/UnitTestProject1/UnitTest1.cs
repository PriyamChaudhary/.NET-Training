using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using CalculatorService;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Calculator calcObj = null;
        public UnitTest1()
        {
            calcObj = new Calculator();
        }
        [TestMethod]
        public void TestMethodForAddMe()
        {

        }
    }
}
