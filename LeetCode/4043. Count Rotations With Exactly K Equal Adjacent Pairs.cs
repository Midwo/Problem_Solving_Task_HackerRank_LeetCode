using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_4043
    {
        ////(4043.) Count Rotations With Exactly K Equal Adjacent Pairs (EASY)
        public int CountRotations(string s, int k)
        {
            int totalResult = 0;
            int length = s.Length;

            for (int startIndex = 0; startIndex < length; startIndex++)
            {
                int correctCount = 0;
                int currIndex = startIndex;

                for (int i = 0; i < length-1; i++)
                {
                    if (currIndex == length)
                    {
                        currIndex = 0;
                    }

                    if (currIndex == length - 1)
                    {
                        if (s[currIndex] == s[0])
                            correctCount++;
                    }
                    else if (s[currIndex] == s[currIndex + 1])
                        correctCount++;

                    currIndex++;
                }

                if(correctCount == k)
                    totalResult++;
            } 

            return totalResult;
        }
    }
}
