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
            int hour = 6;
            int minute = 0;
            Assert.AreEqual(180,Clock.FindAngle(hour,minute));
        }
    }
}

