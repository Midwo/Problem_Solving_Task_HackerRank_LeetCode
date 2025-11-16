using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3683
    {
        ////(3683.) Earliest Time to Finish One Task (EASY)
        public int EarliestTime(int[][] tasks)
        {
            int earliesTime = int.MaxValue;

            for (int i = 0; i < tasks.Length; i++)
            {
                earliesTime = (tasks[i][0] + tasks[i][1]) < earliesTime ? tasks[i][0] + tasks[i][1] : earliesTime;
            }

            return earliesTime;
        }
    }
}
