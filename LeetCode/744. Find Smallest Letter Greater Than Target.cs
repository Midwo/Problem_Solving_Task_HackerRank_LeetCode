using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_744
    {
        ////744. Find Smallest Letter Greater Than Target
        public char NextGreatestLetter(char[] letters, char target)
        {
            int length = letters.Length;
            int left = 0;
            int right = length;

            if (letters[length-1] < target)
            {
                return letters[0];
            }

            while (left < right) 
            {
                int temp = left + (right - left) / 2;
                if (letters[temp] > target)
                {
                    right = temp;
                }
                else
                {
                    left = temp+1;
                }
            }

            return letters[right];
        }

    }
}
