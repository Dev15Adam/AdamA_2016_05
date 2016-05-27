using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdamA_Tentamen.Models;

namespace UnitTestProject1
{
    [TestClass]
    public class CurrentSpeedTest
    {
        [TestMethod]
        public void CurrentSpeed_Test()
        {
            GetCurrentSpeed GCS = new GetCurrentSpeed();

            var actual = GCS.CurrentSpeed(10, 2);
            var expected = 5;

            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void CurrentSpeedNotNull_Test()
        {
            GetCurrentSpeed GCS = new GetCurrentSpeed();

            var actual = GCS.CurrentSpeed(50, 5);

            Assert.IsNotNull(actual);
        }
    }
}
