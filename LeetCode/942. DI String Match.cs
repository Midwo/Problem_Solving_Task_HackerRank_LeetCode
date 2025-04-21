using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_942
    {
        ////(942.) DI String Match (EASY)
        public int[] DiStringMatch(string s)
        {
            int length = s.Length;
            int minValue = 0;
            int maxValue = length;
            List<int> resultList = new List<int>();

            for (int i = 0; i < length; i++)
            {
                if (s[i] == 'I')
                {
                    resultList.Add(minValue);
                    minValue++;
                }
                else
                {
                    resultList.Add(maxValue);
                    maxValue--;
                }
            }
            resultList.Add(minValue);

            return resultList.ToArray();
        }
    }
}
