using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2582
    {
        ////(2582.) Pass the Pillow (EASY)
        public int PassThePillow(int n, int time)
        {
            if (n > time)
            {
                return time+1;
            }

            int howManyCycle = time / (n-1); 
            int restCycle = time % (n - 1);

            if ((howManyCycle & 1) == 1)
            {
                return n - restCycle;
            }
            else
            {
                return restCycle+1;
            }
        }
    }
}
