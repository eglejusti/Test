using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesktopCalculator.Tests
{
    [TestClass]
    public class ArithmeticsTests
    {
        [TestMethod]
        public void FiveDividedBy0ThrowsException()
        {
            //unit test consists of: 1. arrange 2. act 3. assert//

            //arrange//
            int num1 = 5;
            int num2 = 0;
            string action = "/";

            Arithmetics arithmetics = new Arithmetics();
            bool IsDivisionBy0exceptionThrown = false;

            //act// 
            try {

                int actualResult = arithmetics.Calculate(num1, num2, action);
            }
            catch (DivideByZeroException ex)
            {
                IsDivisionBy0exceptionThrown = true;
            }

            //assert//

            Assert.IsTrue(IsDivisionBy0exceptionThrown);




        }
    }
}
