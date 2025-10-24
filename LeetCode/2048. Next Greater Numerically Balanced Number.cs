using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2048
    {
        ////(2048.) Next Greater Numerically Balanced Number (MEDIUM)
        public int NextBeautifulNumber(int n)
        {
            bool status = false;
            bool breakLoop = false;
            n++;

            string stringN = string.Empty;
            while (!status)
            {
                stringN = n.ToString();
                int[] countNumber = new int[10];
                breakLoop = false;
                for (int i = 0; i < stringN.Length; i++)
                {
                    countNumber[stringN[i] - '0']++;
                }
                for (int i = 0; i < countNumber.Length; i++) 
                {
                    if (countNumber[i] != i && countNumber[i] > 0)
                    {
                        breakLoop = true;
                        break;
                    }
                }
                if (breakLoop)
                {
                    n++;
                }
                else
                {
                    status = true;
                }
            }

            return int.Parse(stringN);
        }
    }
}
