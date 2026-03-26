using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2405
    {
        ////(2405.) Optimal Partition of String (MEDIUM)
        public int PartitionString(string s)
        {
            int length = s.Length;

            if (length == 1)
            {
                return 1;
            }

            int howManyPossiblePartition = 0;

            for (int index = 0; index < length; index++)
            {
                int[] countChar = new int[26];
                countChar[s[index] - 'a']++;
                int maxLenght = 1;
                for (int inIndex = index + 1; inIndex < length; inIndex++)
                {
                    countChar[s[inIndex] - 'a']++;
                    if(countChar[s[inIndex] - 'a'] > 1)
                    {
                        break;
                    }
                    maxLenght++;
                }
                howManyPossiblePartition++;
                
                if(index + maxLenght >= length)
                {
                    break;
                }
                index += maxLenght - 1;
            }

            return howManyPossiblePartition;

        }
    }
}
