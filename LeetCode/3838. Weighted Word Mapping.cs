using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3838
    {
        ////(3838.) Weighted Word Mapping (EASY)
        public string MapWordWeights(string[] words, int[] weights)
        {
            var resultChar = new char[words.Length];
            int index = 0;

            foreach (var currWord in words)
            {
                int sumDigit = 0;
                foreach (var currChar in currWord) 
                {
                    sumDigit += weights[currChar - 'a'];
                }
                resultChar[index++] = (char)((int)'z' - (sumDigit % 26));
            }

            return new string(resultChar);
        }
    }
}
