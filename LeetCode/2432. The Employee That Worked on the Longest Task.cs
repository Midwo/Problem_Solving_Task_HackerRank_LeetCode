using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2432
    {
        ////(2432.) The Employee That Worked on the Longest Task (EASY)
        public int HardestWorker(int n, int[][] logs)
        {
            int maxUnits = 0;
            int idEmploye = int.MaxValue;
            int currUnits = 0;
            int lastEnd = 0;
            int currEnd = 0;
            for (int i = 0; i < logs.Length; i++)
            {
                currEnd = logs[i][1];
                currUnits = currEnd - lastEnd;
                lastEnd = currEnd;

                if (currUnits > maxUnits || currUnits == maxUnits && idEmploye > logs[i][0])
                {
                    maxUnits = currUnits;
                    idEmploye = logs[i][0];
                }
            }

            return idEmploye;
        }
    }
}
