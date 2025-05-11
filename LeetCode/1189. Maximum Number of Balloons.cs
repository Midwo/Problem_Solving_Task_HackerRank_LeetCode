using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1189
    {
        ////(1189.) Maximum Number of Balloons (EASY)
        public int MaxNumberOfBalloons(string text)
        {
            Dictionary<char, int> dictionaryBallon = new Dictionary<char, int>() { { 'b', 1 }, { 'a', 1 }, {'l', 2}, {'o', 2 }, {'n', 1 } };
            Dictionary<char, int> dictionaryTextOnlyCharsBallon = new Dictionary<char, int>() { { 'b', 0 }, { 'a', 0 }, { 'l', 0 }, { 'o', 0 }, { 'n', 0 } };
            int result = int.MaxValue;

            foreach (char letter in text)
            {
                if (dictionaryTextOnlyCharsBallon.ContainsKey(letter))
                {
                    dictionaryTextOnlyCharsBallon[letter]++;
                }
            }

            foreach (var item in dictionaryTextOnlyCharsBallon)
            {
                int temp = item.Value / dictionaryBallon[item.Key];
                result = result < temp ? result : temp;
            }

            return result;
        }
    }
}
