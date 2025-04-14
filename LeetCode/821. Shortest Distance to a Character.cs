using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_821
    {
        ////(821.) Shortest Distance to a Character (EASY)
        public int[] ShortestToChar(string s, char c)
        {
            int howManyWithout = 0;

            List<int> listIndexCharC = new List<int>();
            List<int> result = new List<int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    listIndexCharC.Add(i);
                }
            }
            int start = 0;
            int stop = listIndexCharC.Count-1;
            for (int i = 0; i < s.Length; i++)
            {
                int currResult = Math.Abs(i - listIndexCharC[start]); 
                if (start < stop)
                {
                    int currResultNext = Math.Abs(i - listIndexCharC[start + 1]);
                    if (currResult < currResultNext)
                    {
                        result.Add(currResult);
                    }
                    else
                    {
                        result.Add(currResultNext);
                        start++;
                    }
                }
                else
                {
                    result.Add(currResult);
                }
            }

            return result.ToArray();
        }
    }
}
