using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3216
    {
        ////(3216.) Lexicographically Smallest String After a Swap (EASY)
        public string GetSmallestString(string s)
        {
            char[] sChars = s.ToCharArray();
            bool lastNumberIsEven = (((sChars[0] - '0') & 1) == 0);

            int length = s.Length;
            bool currEvenNumberStatus = false;

            for (int i = 1; i < length; i++)
            {
                currEvenNumberStatus = (((sChars[i] - '0') & 1) == 0);

                if (currEvenNumberStatus == lastNumberIsEven && sChars[i] < sChars[i-1])
                {
                    char temp = sChars[i];
                    sChars[i] = sChars[i-1];
                    sChars[i-1] = temp;

                    return new string (sChars);
                }

                lastNumberIsEven = currEvenNumberStatus;
            }

            return s;



            //bool lastNumberIsEven = false;

            //if ((s[0] -'0') % 2 == 0)
            //{
            //    lastNumberIsEven = true;
            //}

            //int length = s.Length;
            //bool currEvenNumberStatus = false;

            //for (int i = 1; i < length; i++) 
            //{
            //    if ((s[i] -'0') % 2 == 0)
            //    {
            //        currEvenNumberStatus = true;    
            //    }
            //    else
            //    {
            //        currEvenNumberStatus = false;
            //    }

            //    if (currEvenNumberStatus == lastNumberIsEven && s[i] < s[i-1])
            //    {
            //        return s[0..(i-1)] + s[i] + s[i-1] + s[(i + 1)..length];
            //    }

            //    lastNumberIsEven = currEvenNumberStatus;
            //}

            //return s;
        }
    }
}
