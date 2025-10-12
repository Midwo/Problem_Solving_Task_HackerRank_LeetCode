using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3184
    {
        ////(3184.) Count Pairs That Form a Complete Day I (EASY)
        public int CountCompleteDayPairs(int[] hours)
        {
            int count = 0;
            int length = hours.Length;

            for (int i = 0; i < length-1; i++)
            {
                int firstValue = hours[i];
                for (int j = i+1; j < length; j++)
                {
                    if ((firstValue + hours[j])%24 == 0)
                    {
                        count++;
                    }
                }
            }
            
            return count;
        }
    }
}
