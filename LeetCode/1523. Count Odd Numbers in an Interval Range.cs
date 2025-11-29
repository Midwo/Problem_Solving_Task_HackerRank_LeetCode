using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1523
    {
        ////(1523.) Count Odd Numbers in an Interval Range(EASY)
        public int CountOdds(int low, int high)
        {
            if(low % 2 == 0)
            {
                low++;
            }
            if (high % 2 == 0) 
            {
                high--;
            }

            return (high-low)/ 2+1;
        }
    }
}
