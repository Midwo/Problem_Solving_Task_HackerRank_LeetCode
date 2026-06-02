using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2375
    {
        ////(2375.) Construct Smallest Number From DI String (MEDIUM)
        public string SmallestNumber(string pattern)
        {
            int insertValue = 1;
            int length = pattern.Length;
            var intSmallestNumber = new int[length+1];
            for (int i = 0; i < length; i++)
            {
                if (pattern[i] == 'I' && i > 0 && intSmallestNumber[i - 1] == 0)
                {
                    intSmallestNumber[i] = insertValue++;
                    int index = i - 1;
                    while (index >= 0 && intSmallestNumber[index] == 0)
                    {
                        intSmallestNumber[index] = insertValue++;
                        index--;
                    }
                }
                else if (pattern[i] == 'I')
                {
                    intSmallestNumber[i] = insertValue++;
                }
            }


            if (pattern[length-1] == 'I')
            {
                intSmallestNumber[length] = insertValue++;
            }
            else if (intSmallestNumber[length] == 0)
            {
                int index = length;
                while (index >= 0 && intSmallestNumber[index] == 0)
                {
                    intSmallestNumber[index] = insertValue++;
                    index--;
                }
            }            
            
            return string.Join(null, intSmallestNumber);
        }
    }
}
