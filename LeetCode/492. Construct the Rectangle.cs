using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_492
    {
        ////(492.) Construct the Rectangle (EASY)
        public int[] ConstructRectangle(int area)
        {
            int l = 1;
            int w = 1;
            for (int i = 1; i <= Math.Sqrt(area); i++) 
            {
                if (area % i == 0)
                {
                    l = area / i;
                    w = i; 
                }
            }
            return new int[] { l, w };
        }
    }
}
