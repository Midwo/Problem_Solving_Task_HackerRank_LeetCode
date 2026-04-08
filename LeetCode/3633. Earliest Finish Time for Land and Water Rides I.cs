using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3633
    {
        ////(3633.) Earliest Finish Time for Land and Water Rides I (EASY)
        public int EarliestFinishTime(int[] landStartTime, int[] landDuration, int[] waterStartTime, int[] waterDuration)
        {
            int earLiestFinishTime = int.MaxValue;
            int lengthLand = landStartTime.Length;
            int lengthWater = waterStartTime.Length;

            for (int indexLand = 0; indexLand < lengthLand; indexLand++)
            {
                int currTimeStart = landStartTime[indexLand];
                int duration = landDuration[indexLand];
                int currTimeEnd = landStartTime[indexLand] + duration;

                for (int indexWater = 0; indexWater < lengthWater; indexWater++)
                {
                    if(currTimeEnd >= waterStartTime[indexWater])
                    {
                        earLiestFinishTime = Math.Min(earLiestFinishTime, currTimeEnd + waterDuration[indexWater]);
                    }
                    else
                    {
                        earLiestFinishTime = Math.Min(earLiestFinishTime, waterStartTime[indexWater] + waterDuration[indexWater]);
                    }

                    if (waterStartTime[indexWater] + waterDuration[indexWater] >= currTimeStart)
                    {
                        earLiestFinishTime = Math.Min(earLiestFinishTime, waterStartTime[indexWater] + waterDuration[indexWater] + duration);
                    }
                    else
                    {
                        earLiestFinishTime = Math.Min(earLiestFinishTime, currTimeEnd);
                    }
                }
            }

            return earLiestFinishTime;
        }
    }
}
