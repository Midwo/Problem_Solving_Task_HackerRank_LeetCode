using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1318
    {
        ////(1318.) Minimum Flips to Make a OR b Equal to c (MEDIUM)
        public int MinFlips(int a, int b, int c)
        {
            int countFlips = 0;

            string stringA = Convert.ToString(a, 2).PadLeft(30, '0');
            string stringB = Convert.ToString(b, 2).PadLeft(30, '0');
            string stringC = Convert.ToString(c, 2).PadLeft(30, '0');

            for (int index = 0; index < 30; index++) 
            {
                if (stringC[index] == '1')
                {
                    if (stringA[index] == '0' && stringB[index] == '0')
                        countFlips++;
                }
                else
                {
                    if (stringB[index] == '1')
                        countFlips++;
                    if (stringA[index] == '1')
                        countFlips++;
                }
            }

            return countFlips;
        }
    }
}
