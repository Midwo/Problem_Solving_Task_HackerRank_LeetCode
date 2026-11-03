using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2451
    {
        ////(2451.) Odd String Difference (EASY)
        public string OddString(string[] words)
        {
            int length = words.Length;

            for (int indexInWord = 0; indexInWord < words[0].Length - 1; indexInWord++)
            {
                int[][] diffCharCountLastIndexWords = new int[2][];

                diffCharCountLastIndexWords[0] = new int[] { words[0][indexInWord + 1] - words[0][indexInWord], 1, 0 };
                diffCharCountLastIndexWords[1] = new int[] {0, 0, 0 };

                bool differenceStatus = false;
                for (int indexWord = 1; indexWord < length; indexWord++)
                {
                    int diff = words[indexWord][indexInWord + 1] - words[indexWord][indexInWord];

                    if (diffCharCountLastIndexWords[0][0] == diff)
                        diffCharCountLastIndexWords[0][1]++;
                    else
                    {
                        differenceStatus = true;
                        if (diffCharCountLastIndexWords[1][1] == 0)
                            diffCharCountLastIndexWords[1] = [diff, 1, indexWord];
                        else
                            diffCharCountLastIndexWords[1][1]++;
                    }
                }
                if (differenceStatus)
                {
                    if (diffCharCountLastIndexWords[0][1] == 1)
                        return words[diffCharCountLastIndexWords[0][2]];
                    else if (diffCharCountLastIndexWords[1][1] == 1)
                        return words[diffCharCountLastIndexWords[1][2]];
                }
            }

            return "";
        }
    }
}
