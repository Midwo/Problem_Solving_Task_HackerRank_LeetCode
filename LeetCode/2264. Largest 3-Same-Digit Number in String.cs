using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2264
    {
        ////(2264.) Largest 3-Same-Digit Number in String (EASY)
        public string LargestGoodInteger(string num)
        {
            char bestChar = 'x';
            char lastChar = num[0];
            int counter = 1;
            string currResult = string.Empty;

            for (int i = 1; i < num.Length; i++)
            {
                if (lastChar == num[i])
                {
                    counter++;
                    if(counter == 3)
                    {
                        if (bestChar == 'x')
                        {
                            bestChar = num[i];
                            if (bestChar == '9')
                            {
                                break;

                            }
                        }
                        else
                        {
                            if (bestChar < num[i])
                            {
                                bestChar = num[i];
                                if (bestChar == '9')
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    counter = 1;
                    lastChar = num[i];
                }
            }

            if(bestChar == 'x')
            {
                return "";
            }

            return new string(bestChar, 3);
        }
    }
}
