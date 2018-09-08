using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClockAngle.Models;

namespace ClockAngle.TestTools
{
    [TestClass]
    public class ClockAngleTest
    {
        [TestMethod]
        public void FindAngle_SameHandsLocation_0()
        {
            int hour = 3;
            int minute = 15;
            Assert.AreEqual(0,Clock.FindAngle(hour,minute));
        }
        [TestMethod]
        public void FindAngle_ReturnAngleBetweenHands_30()
        {
            int hour = 1;
            int minute = 45;
            Assert.AreEqual(120,Clock.FindAngle(hour,minute));
        }
    }
}

