using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_868
    {
        ////(868.) Binary Gap (EASY)
        public int BinaryGap(int n)
        {
            string binaryString = Convert.ToString(n, 2);
            int result = 0;
            int indexFor1 = -1;
            for (int i = 0; i < binaryString.Length; i++)
            {
                if (binaryString[i] == '1')
                {
                    if (indexFor1 >= 0)
                    {
                        result = Math.Max(result, i - indexFor1);
                        indexFor1 = i;
                    }
                    else
                    {
                        indexFor1 = i;
                    }
                }
            }

            return result;
        }
    }
}
