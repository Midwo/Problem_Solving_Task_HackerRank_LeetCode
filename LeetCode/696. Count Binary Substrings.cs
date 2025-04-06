using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_696
    {
        ////(696.) Count Binary Substrings (EASY)
        public int CountBinarySubstrings(string s)
        {
            int result = 0;
            int howManyZeroCont = 0;
            int howManyOneCont = 0;
            char lastChar = s[0];

            if (s[0] == '1')
            {
                lastChar = '1';
                howManyZeroCont++;
            }
            else
            {
                lastChar = '0';
                howManyOneCont++;
            }

            for (int i = 1; i < s.Length; i++)
            {
                if (lastChar == s[i])
                {
                    if (lastChar == '1')
                    {
                        if (howManyOneCont == 0)
                        {
                            howManyOneCont += 2;
                        }
                        else
                        {
                            howManyOneCont++;
                        }
                        if (howManyOneCont <= howManyZeroCont && howManyOneCont > 1 && howManyZeroCont > 1)
                        {
                            result++;
                        }
                    }
                    else
                    {
                        if (howManyZeroCont == 0)
                        {
                            howManyZeroCont += 2;
                        }
                        else
                        {
                            howManyZeroCont++;
                        }
                        if (howManyZeroCont <= howManyOneCont && howManyOneCont > 1 && howManyZeroCont > 1)
                        {
                            result++;
                        }
                    }
                }
                else
                {
                    result++;
                    if (lastChar == '1')
                    {
                        howManyZeroCont = 1;
                    }
                    else
                    {
                        howManyOneCont = 1;
                    }
                    lastChar = s[i];
                }
            }

            return result;
        }

    }
}

