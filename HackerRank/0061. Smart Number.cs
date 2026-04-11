using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0061
    {
        ////61. Smart Number (EASY)     
        public bool is_smart_number(int num)
        {
            int val = (int)Math.Sqrt(num);
            if (val * val == num)
                return true;
            return false;
        }
    }
}
