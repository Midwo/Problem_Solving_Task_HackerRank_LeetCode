using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1980
    {
        ////(1980.) Find Unique Binary String (MEDIUM)
        public string FindDifferentBinaryString(string[] nums)
        {
            HashSet<string> hashSetNums = new HashSet<string>();

            foreach (string s in nums)
            {
                hashSetNums.Add(s);
            }

            int countNums = nums.Length;
            int length = nums[0].Length;

            return TryGenerateUniqueString("", hashSetNums, length, 0);
        }

        private string TryGenerateUniqueString(string currString, HashSet<string> hashSetNums, int length, int index)
        {
            if (length == index)
            {
                if (!hashSetNums.Contains(currString))
                {
                    return currString;
                }
                return "-1";
            }

            if (index >= length)
            {
                return "-1";
            }

            string result = TryGenerateUniqueString(currString + "0", hashSetNums, length, index + 1);
            if (result != "-1")
            {
                return result;
            }
            return TryGenerateUniqueString(currString + "1", hashSetNums, length, index + 1);
        }     
    }
}
