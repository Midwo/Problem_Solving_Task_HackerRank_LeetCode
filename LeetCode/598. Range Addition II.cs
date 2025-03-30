using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_598
    {
        ////(598.) Range Addition II (EASY)
        public int MaxCount(int m, int n, int[][] ops)
        {
            int opsLength = ops.Length;
            
            if(opsLength == 0)
            {
                return m * n;
            }

            int minM = int.MaxValue;
            int minN = int.MaxValue;

            for(int i = 0; i < opsLength; i++)
            {
                if (ops[i][0] < minM)
                {
                    minM = ops[i][0];
                }
                if (ops[i][1] < minN)
                {
                    minN = ops[i][1];
                }
                ////Console.WriteLine(string.Join(',', ops[i]));
            }
            return minN * minM;
        }
    }
}
