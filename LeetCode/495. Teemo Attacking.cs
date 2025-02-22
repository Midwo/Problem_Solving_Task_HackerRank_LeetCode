using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_495
    {
        ////(495.) Teemo Attacking (EASY)
        public int FindPoisonedDuration(int[] timeSeries, int duration)
        {
            int result = 0;
            int currLastTime = 0; 
            for (int i = 0; i < timeSeries.Length; i++)
            {
                if(result == 0)
                {
                    currLastTime = timeSeries[i]+duration-1;
                    result += duration;
                }
                else
                {
                    if (currLastTime >= timeSeries[i])
                    {
                        result += timeSeries[i] + duration - currLastTime-1;
                        currLastTime = timeSeries[i] + duration-1;
                    }
                    else
                    {
                        currLastTime = timeSeries[i] + duration-1;
                        result += duration;
                    }
                }
            }
            return result;
        }
    }
}
