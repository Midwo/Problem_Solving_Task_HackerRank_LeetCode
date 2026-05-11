using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3857
    {
        ////(3857.) Minimum Cost to Split into Ones
        public int MinCost(int n)
        {
            ////Solution 1 (Better - mathematical)
            return (n * (n - 1) / 2);


            ////Solution 2 (Manual, Worse)
            //int sum = 0;
            //for (int i = 1; i < n; i++)
            //{
            //    sum += i;
            //}
            //return sum;
        }
    }
}
