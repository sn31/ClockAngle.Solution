using System.Linq;
using System;
namespace ClockAngle.Models
{
    public class Clock
    {
        public static int FindAngle(int hour, int minute)
        {
            int hourLocation = hour * 5;
            int degreeDiff = Math.Abs(hourLocation-minute)*6;
            int result = (degreeDiff>180) ? (360-degreeDiff) : degreeDiff;
            return result;
        }
    }
}
