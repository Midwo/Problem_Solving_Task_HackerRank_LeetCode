using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1450
    {
        ////(1450.) Number of Students Doing Homework at a Given Time (EASY)
        public int BusyStudent(int[] startTime, int[] endTime, int queryTime)
        {
            int count = 0;

            for (int i = 0; i < endTime.Length; i++)
            {
                if (endTime[i] >=  queryTime && startTime[i] <= queryTime)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
