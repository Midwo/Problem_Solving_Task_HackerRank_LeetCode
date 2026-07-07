using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1881
    {
        ////(1881.) Maximum Value after Insertion (MEDIUM)
        public string MaxValue(string n, int x)
        {
            int length = n.Length;
            char charX = (char)('0' + x);

            if (n[0] == '-')
            {
                for (int index = 1; index < length; index++)
                {
                    if (n[index] > charX)
                    {
                        return n[0..(index)] + x + n[(index)..length];
                    }
                }
            }
            else
            {
                for (int index = 0; index < length; index++)
                {
                    if (n[index] < charX)
                    {
                        return n[0..(index)] + x + n[(index)..length];
                    }
                }
            }

            return n + x;
        }
    }
}
