using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1629
    {
        ////(1629.) Slowest Key (EASY)
        public char SlowestKey(int[] releaseTimes, string keysPressed)
        {
            char longestChar = keysPressed[0];
            int longestTime = releaseTimes[0];
            int lastValue = longestTime;

            for (int i = 1; i < releaseTimes.Length; i++)
            {
                int currEndTime = releaseTimes[i];
                int currDuration = currEndTime - lastValue;
                lastValue = currEndTime;

                if(longestTime < currDuration || longestTime == currDuration && keysPressed[i] > longestChar)
                {
                    longestChar = keysPressed[i];
                    longestTime = currDuration;
                }
            }

            return longestChar;
        }
    }
}
