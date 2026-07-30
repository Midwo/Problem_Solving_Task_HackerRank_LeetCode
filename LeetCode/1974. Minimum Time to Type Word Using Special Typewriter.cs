using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1974
    {
        ////(1974.) Minimum Time to Type Word Using Special Typewriter (EASY)
        public int MinTimeToType(string word)
        {
            int lastTypeNumberChar = 1;
            int minTimeToType = word.Length;

            foreach (char currChar in word)
            {
                int numberCurrChar = currChar - 'a' + 1;
                int minDistance = Math.Abs(numberCurrChar - lastTypeNumberChar);
                minTimeToType += Math.Min(minDistance, 26 - minDistance); 
                lastTypeNumberChar = numberCurrChar;
            }

            return minTimeToType;
        }
    }
}
