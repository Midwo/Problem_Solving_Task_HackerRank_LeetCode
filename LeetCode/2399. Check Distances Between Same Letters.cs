using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2399
    {
        ////(2399.) Check Distances Between Same Letters (EASY)
        public bool CheckDistances(string s, int[] distance)
        {
            bool[] statusLeeter = new bool[26];
            int length = s.Length;
            int nextIndex;
            int currIndexChar;

            for (int i = 0; i < length; i++)
            {
                currIndexChar = s[i] - 'a';
                if (!statusLeeter[currIndexChar])
                {
                    nextIndex = distance[currIndexChar] + i + 1;
                    if (nextIndex >= length || s[nextIndex] - 'a' != currIndexChar)
                    {
                        return false;
                    }
                    statusLeeter[currIndexChar] = true;
                }
            }

            return true;
        }
    }
}
