using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3498
    {
        ////(3498.) Reverse Degree of a String (EASY)
        public int ReverseDegree(string s)
        {
            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                //result += s[i];
                result += ('a'-s[i]+26)*(i+1);
            }

            return result;
        }
    }
}
