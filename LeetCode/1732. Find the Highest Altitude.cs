using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1732
    {
        ////(1732.) Find the Highest Altitude (EASY)
        public int LargestAltitude(int[] gain)
        {
            //// 0ms, Beats: 100%

            int highestAlitute = 0;
            int sum = 0;
            for (int i = 0; i < gain.Length; i++)
            {
                sum += gain[i];
                highestAlitute = Math.Max(highestAlitute, sum);
            }

            return highestAlitute;
        }
    }
}
