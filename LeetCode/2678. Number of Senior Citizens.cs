using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2678
    {
        ////(2678.) Number of Senior Citizens (EASY)
        public int CountSeniors(string[] details)
        {
            ////0ms, Beats: 100.00%
            int count = 0;

            foreach (string item in details) 
            {
                if (item[11] >= 54)
                {
                    if (item[11] > 54)
                    {
                        count++;
                    }
                    else if (item[12] > 48)
                    {
                        count++;
                    }
                }       
            }

            return count;
        }
    }
}
