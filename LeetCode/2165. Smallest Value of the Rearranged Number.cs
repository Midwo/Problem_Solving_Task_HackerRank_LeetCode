using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2165
    {
        ////(2165.) Smallest Value of the Rearranged Number (MEDIUM)
        public long SmallestNumber(long num)
        {
            StringBuilder stringBuilderSmallestNumber = new StringBuilder();

            string stringNum = num.ToString();
            bool statusPlusValue = true;

            if (stringNum[0] == '-')
            {
                statusPlusValue = false;
                stringBuilderSmallestNumber.Append("-");
            }

            int[] countNumbers = new int[10];

            if (statusPlusValue)
            {
                foreach (char currChar in stringNum)
                {
                    countNumbers[currChar-'0']++;
                }
                
                bool statusAddingZeros = false;

                for (int i = 1; i < 10; i++)
                {
                    if (countNumbers[i] > 0)
                    {
                        int temp = '0' + i;
                        if (!statusAddingZeros)
                        {
                            stringBuilderSmallestNumber.Append((char)temp);
                            statusAddingZeros = true;
                            stringBuilderSmallestNumber.Append('0', countNumbers[0]);
                            stringBuilderSmallestNumber.Append((char)temp, countNumbers[i]-1);
                        }
                        else
                        {
                            stringBuilderSmallestNumber.Append((char)temp, countNumbers[i]);
                        }
                    }
                }
            }
            else
            {
                for (int i = 1; i < stringNum.Length; i++)
                {
                    countNumbers[stringNum[i] - '0']++;
                }

                for (int i = 9; i >= 0; i--)
                {
                    if (countNumbers[i] > 0)
                    {
                        int temp = '0' + i;
                        stringBuilderSmallestNumber.Append((char)temp, countNumbers[i]);
                    }
                }
            }

            if(stringBuilderSmallestNumber.Length == 0)
            {
                return 0;
            }

            return long.Parse(stringBuilderSmallestNumber.ToString());
        }
    }
}
