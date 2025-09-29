using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2315
    {
        ////(2315.) Count Asterisks (EASY)
        public int CountAsterisks(string s)
        {
            int count = 0;
            bool active = true;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '|')
                {
                    if (active)
                    {
                        active = false;
                    }
                    else 
                    {
                        active = true;
                    }
                }
                if (s[i] == '*' && active)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
