using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_338
    {
        ////(338.) Counting Bits (EASY)
        public int[] CountBits(int n)
        {
            List<int> result = new List<int>();
            int howManyOne = 0;
            for (int i = 0; i <= n; i++)
            {
                howManyOne = 0;  
                foreach(var item in Convert.ToString(i, 2))
                {
                    if (item == (char)49)
                    {
                        howManyOne++;
                    }
                }
                result.Add(howManyOne);
            }
            return result.ToArray();
        }
    }
}
