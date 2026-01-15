using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3258
    {
        ////(3258.) Count Substrings That Satisfy K-Constraint I (EASY)
        public int CountKConstraintSubstrings(string s, int k)
        {
            ////Solution: Brute Force
            int count = 0;
            int length = s.Length;

            for (int i = 0; i < length; i++)
            {
                int countZero = 0;
                int countOne = 0;

                if (s[i] == '1')
                {
                    countOne = 1;
                }
                else
                {
                    countZero = 1;
                }

                for (int j = i+1; j < length; j++)
                {
                    if (s[j] == '1')
                    {
                        countOne++;
                    }
                    else
                    {
                        countZero++;
                    }

                    if (countOne > k && countZero > k)
                    {
                        break;
                    }

                    count++;
                }

                count ++;
            } 
            return count;
        }
    }
}
