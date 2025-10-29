using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2960
    {
        ////(2960.) Count Tested Devices After Test Operations (EASY)
        public int CountTestedDevices(int[] batteryPercentages)
        {
            ////0ms, Beats: 100.00%
            
            int countTestedDevices = 0;

            for (int i = 0; i < batteryPercentages.Length; i++)
            {
                if (batteryPercentages[i] - countTestedDevices > 0)
                {
                    countTestedDevices++;
                }
            }
            return countTestedDevices;
        }
    }
}
