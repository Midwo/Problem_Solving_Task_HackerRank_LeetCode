using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_830
    {
        ////(830.) Positions of Large Groups (EASY)
        public IList<IList<int>> LargeGroupPositions(string s)
        {
            IList<IList<int>> result = new List<IList<int>>();

            int start = 0;
            char lastChar = s[0];
            int count = 1;
            int length = s.Length;

            for (int i = 1; i < length; i++) 
            {
                char currChar = s[i];
                if (currChar == lastChar)
                {
                    count++;
                }
                else
                {
                    if (count >= 3)
                    {
                        result.Add(new List<int>() {start, i-1});
                    }
                    count = 1;
                    lastChar = currChar;
                    start = i;
                }
            }
            if (start + 2 <= length)
            {
                result.Add(new List<int>() { start, length - 1 });
            }

            return result;
        }
    }
}
