using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3271
    {
        ////(3271.) Hash Divided String (MEDIUM)
        public string StringHash(string s, int k)
        {
            StringBuilder sb = new StringBuilder();
            int count = 0;
            int currValue = 0;

            for (int i = 0; i <  s.Length; i++)
            {
                count++;
                currValue += (s[i] - 'a');
                if (count == k)
                {
                    count = 0;
                    sb.Append(Convert.ToChar((currValue % 26)+'a'));
                    currValue = 0;
                }
            }

            return new string(sb.ToString());
        }
    }
}
