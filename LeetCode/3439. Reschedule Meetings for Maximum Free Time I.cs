using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3439
    {
        ////(3439.) Reschedule Meetings for Maximum Free Time I (MEDIUM)
        public int MaxFreeTime(int eventTime, int k, int[] startTime, int[] endTime)
        {
            int result = 0;

            List<int> breaksTimesList = new List<int>();

            for (int i = 0; i < startTime.Length; i++)
            {
                if (i == 0)
                {
                    if (startTime[i] > 0)
                    {
                        breaksTimesList.Add(startTime[i]);
                    }
                }
                else if (endTime[i - 1] < startTime[i])
                {
                    breaksTimesList.Add(startTime[i] - endTime[i - 1]);
                }
                else
                {
                    breaksTimesList.Add(0);
                }
            }
            if (endTime[(endTime.Length - 1)] < eventTime)
            {
                breaksTimesList.Add(eventTime - endTime[(endTime.Length - 1)]);
            }

            int currSum = 0;

            if (k >= breaksTimesList.Count)
            {
                for (int i = 0; i < breaksTimesList.Count; i++)
                {
                    currSum += breaksTimesList[i];
                }
                return currSum;
            }

            int outValue = breaksTimesList[0];

            for (int j = 0; j <= k; j++)
            {
                currSum += breaksTimesList[j];
            }

            result = Math.Max(result, currSum);

            for (int i = 1; i < breaksTimesList.Count - k; i++)
            {
                currSum += breaksTimesList[k + i] - outValue;
                result = Math.Max(result, currSum);
                outValue = breaksTimesList[i];
            }

            return result;
        }
    }
}
