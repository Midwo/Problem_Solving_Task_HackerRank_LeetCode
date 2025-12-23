using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2054
    {
        ////(2054.) Two Best Non-Overlapping Events (MEDIUM)
        public int MaxTwoEvents(int[][] events)
        {
            int length = events.Length;
            events = events.OrderBy(e => e[0]).ToArray();
            int sumMax = 0;
            int currValue = 0;

            int currMaxValueTable = 0;
            int[] maxValueTable = new int[length];

            for (int i = length -1; i >= 0; i--)
            { 
                if(currMaxValueTable < events[i][2])
                {
                    currMaxValueTable = events[i][2];
                }
                maxValueTable[i] = currMaxValueTable;
            }

            if (events[0][0] == events[length - 1][0])
            {
                return maxValueTable[0];
            }

            for (int i = 0; i < length; i++)
            {
                currValue = events[i][2];
                int end = events[i][1];

                int searchIndex = length / 2+1;

                int right = length;
                int left = i;
                searchIndex = left + (right - left) / 2 + 1;
                while (left < right && searchIndex < length)
                {
                    if (events[searchIndex][0] < end)
                    {
                        left = searchIndex;
                    }
                    else if (events[searchIndex][0] == end)
                    {
                        left++;
                    }
                    else
                    {
                        right = searchIndex-1;
                    }
                    searchIndex = left + (right - left) / 2+1;
                }
                if (right+1 >= length)
                {
                    if(left < right && i+1 < length && end < events[i+1][0])
                    {
                        sumMax = sumMax < currValue + maxValueTable[i + 1] ? currValue + maxValueTable[i + 1] : sumMax;
                    }
                    sumMax = sumMax < currValue? currValue : sumMax;
                }
                else
                {
                    sumMax = sumMax < currValue + maxValueTable[right + 1] ? currValue + maxValueTable[right + 1] : sumMax;
                }
            }

            return sumMax;
        }
    }
}
