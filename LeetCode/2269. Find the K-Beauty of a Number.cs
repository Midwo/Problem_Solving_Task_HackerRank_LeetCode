using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2269
    {
        ////(2269.) Find the K-Beauty of a Number (EASY)
        public int DivisorSubstrings(int num, int k)
        {
            int countKBeauty = 0;
            string numToString = num.ToString();
            int currValue = 0;

            for (int i = 0; i < numToString.Length-k+1; i++)
            {
                currValue = int.Parse(numToString[i..(i + k)]);
                if (currValue > 0 && num % currValue == 0)
                {
                    countKBeauty++;
                }
            }

            return countKBeauty;
        }
    }
}
