using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1404
    {
        ////(1404.) Number of Steps to Reduce a Number in Binary Representation to One (MEDIUM)
        public int NumSteps(string s)
        {
            int howManySteps = 0;
            int add = 0;

            for (int i = s.Length-1; i > 0; i--) 
            {
                int currBit = s[i] - '0';    

                if(currBit + add == 1)
                {
                    howManySteps += 2;
                    add = 1;
                }
                else
                {
                    howManySteps++;
                }
            }    

            return howManySteps + add;
        }
    }
}
