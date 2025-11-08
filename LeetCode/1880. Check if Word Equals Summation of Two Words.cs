using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1880
    {
        ////(1880.) Check if Word Equals Summation of Two Words (EASY)
        public bool IsSumEqual(string firstWord, string secondWord, string targetWord)
        {
            int firstValue = 0;
            int secondValue = 0;
            int targetValue = 0;

            int currLength = 0;   
            for (int i = targetWord.Length - 1; i >= 0; i--) 
            {
                targetValue += (int)Math.Pow(10, currLength) * (targetWord[i] - 'a');
                currLength++;
            }

            currLength = 0;
            for (int i = firstWord.Length - 1; i >= 0; i--)
            {
                firstValue += (int)Math.Pow(10, currLength) * (firstWord[i] - 'a');
                currLength++;
            }

            currLength = 0;
            for (int i = secondWord.Length - 1; i >= 0; i--)
            {
                secondValue += (int)Math.Pow(10, currLength) * (secondWord[i] - 'a');
                currLength++;
            }

            if (secondValue + firstValue == targetValue)
            {
                return true;
            }

            return false;
        }
    }
}
