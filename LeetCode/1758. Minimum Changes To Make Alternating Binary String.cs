using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1758
    {
        ////(1758.) Minimum Changes To Make Alternating Binary String (EASY)
        public int MinOperations(string s)
        {
            int countOperationStart0 = 0;
            int countOperationStart1 = 0;
            bool statusSeachr0 = true;

            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0)
                {
                    if (s[i] == '1')
                    {
                        countOperationStart0++;
                    }
                    else
                    {
                        countOperationStart1++;
                    }
                }
                else
                {
                    if (statusSeachr0)
                    {
                        if (s[i] == '1')
                        {
                            countOperationStart0++;
                        }
                        else
                        {
                            countOperationStart1++;
                        }
                    }
                    else
                    {
                        if (s[i] == '0')
                        {
                            countOperationStart0++;
                        }
                        else
                        {
                            countOperationStart1++;
                        }
                    }
                }

                statusSeachr0 = !statusSeachr0;
            }



            return Math.Min(countOperationStart0, countOperationStart1);
        }
    }
}
