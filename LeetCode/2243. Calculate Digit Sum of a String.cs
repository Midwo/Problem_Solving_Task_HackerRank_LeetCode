using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2243
    {
        ////(2243.) Calculate Digit Sum of a String (EASY)
        public string DigitSum(string s, int k)
        {
            int lengthS = s.Length;
            string newS = string.Empty;

            if (lengthS <= k)
                return s;

            int sum = 0;
            int counter = 0;

            for (int index = 0; index < lengthS; index++)
            {
                sum += s[index] -'0';

                counter++;
                if (counter == k)
                {
                    newS += sum;
                    sum = 0;
                    counter = 0;
                }
            }

            if (counter > 0)
                newS += sum;

            while (newS.Length > k)
            {
                string tempS = string.Empty;
                sum = 0;
                counter = 0;

                for (int index = 0; index < newS.Length; index++) 
                {
                    sum += newS[index] - '0';

                    counter++;
                    if (counter == k)
                    {
                        tempS += sum;
                        sum = 0;
                        counter = 0;
                    }
                }

                if (counter > 0)
                    tempS += sum;

                newS = tempS;
            }

            return newS;
        }
    }
}
