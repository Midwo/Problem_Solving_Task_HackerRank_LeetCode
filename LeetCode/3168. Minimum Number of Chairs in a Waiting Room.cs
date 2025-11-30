using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3168
    {
        ////(3168.) Minimum Number of Chairs in a Waiting Room (EASY)
        public int MinimumChairs(string s)
        {
            int minChairs = 0;
            int currChairs = 0;
            foreach (char c in s) 
            { 
                if(c == 'E')
                {
                    currChairs++;
                    minChairs = minChairs < currChairs? currChairs : minChairs;
                }
                else
                {
                    currChairs--;
                }
            }
            return minChairs;
        }
    }
}
