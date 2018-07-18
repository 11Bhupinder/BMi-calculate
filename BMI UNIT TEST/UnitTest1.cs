using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BMi_calculate;

namespace BMI_UNIT_TEST
{
    [TestClass]
    public class UnitTest1
    {     
        Form1 testForm1 = new Form1();

          [TestMethod]
        public void TestMethod1()
        {
            Double result;
            result = 18.0;
            Assert.IsTrue(result < 18.5);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Double result;
            result = 18.85;
            Assert.IsTrue(result >= 18.6 && result <= 24.9);
        }
    }
}
