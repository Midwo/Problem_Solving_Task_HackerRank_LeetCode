using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1344
    {
        ////(1344.) Angle Between Hands of a Clock (MEDIUM)
        public double AngleClock(int hour, int minutes)
        {
            double angleMinutes = (double)minutes * 6;
            double angleHour = 0; 
            
            if(hour == 12)
            {
                angleHour = 6 * (double)minutes / 60 * 5;
            }
            else
            {
                angleHour = (double)hour * 6 * 5 + 6 * (double)minutes / 60 * 5;
            }

            double minAngle = Math.Abs(angleMinutes - angleHour);
            minAngle = Math.Min(minAngle, 360-minAngle);
            return minAngle;
        }
    }
}
