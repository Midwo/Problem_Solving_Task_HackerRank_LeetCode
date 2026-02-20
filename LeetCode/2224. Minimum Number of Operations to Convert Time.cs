using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2224
    {
        ////(2224.) Minimum Number of Operations to Convert Time (EASY)
        public int ConvertTime(string current, string correct)
        {
            int sumCurrentMinutes = int.Parse(current[0..2]) * 60 + int.Parse(current[3..5]);
            int sumCorrectMinutes = int.Parse(correct[0..2]) * 60 + int.Parse(correct[3..5]);

            int diffMinutes = sumCorrectMinutes - sumCurrentMinutes;

            int countOperations = diffMinutes / 60;
            diffMinutes %= 60;
            countOperations += diffMinutes / 15;
            diffMinutes %= 15;
            countOperations += diffMinutes / 5;
            diffMinutes %=5;
            countOperations += diffMinutes / 1;

            return countOperations;
        }
    }
}
