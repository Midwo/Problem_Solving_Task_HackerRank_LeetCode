using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3794
    {
        ////(3794.) Reverse String Prefix (EASY)
        public string ReversePrefix(string s, int k)
        {
            ////Solution 1 -> char[]
            var resultTableChar = s.ToCharArray();

            for (int i = 0; i < k; i++)
            {
                resultTableChar[i] = s[k - i -1];
            }

            return new string(resultTableChar);

            ////Solution 2 -> StringBuider
            //var resultStringBuilder = new StringBuilder();

            //for (int i = k - 1; i >= 0; i--) 
            //{
            //    resultStringBuilder.Append(s[i]);
            //} 

            //for (int i = k; i < s.Length; i++)
            //{
            //    resultStringBuilder.Append(s[i]);
            //}

            //return resultStringBuilder.ToString();
        }
    }
}
