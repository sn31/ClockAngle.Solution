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
    }
}

