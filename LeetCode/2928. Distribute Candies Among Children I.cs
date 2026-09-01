using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2928
    {
        ////(2928.) Distribute Candies Among Children I (EASY)
        public int DistributeCandies(int n, int limit)
        {
            int result = 0;

            for (int firstChild = 0; firstChild <= limit; firstChild++) 
            { 
                for (int secondChild = 0; secondChild <= limit; secondChild++)
                {
                    if(firstChild + secondChild <= n && n - firstChild - secondChild <= limit)
                        result++;
                }
            }

            return result;
        }
    }
}
