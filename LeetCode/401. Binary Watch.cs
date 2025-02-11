using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_401
    {
        ////(401.) Binary Watch (EASY)
        public IList<string> ReadBinaryWatch(int turnedOn)
        {
            IList<String> result = new List<string>();
            for (int h = 0; h < 12; h++)
            {
                for (int m = 0; m < 60; m++)
                {
                    if (BitCount(h) + BitCount(m) == turnedOn)
                    {
                        result.Add($"{h}:{m:00}");
                    }
                }
            }
            return result;
        }
        private static int BitCount(int num)
        {
            var result = 0;
            while (num > 0)
            {
                result++;
                num &= num - 1;
            }
            return result;
        }
    }
}
