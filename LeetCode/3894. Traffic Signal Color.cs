using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3894
    {
        ////(3894.) Traffic Signal Color (EASY)
        public string TrafficSignal(int timer)
        {
            if (timer > 30 && timer <= 90)
                return "Red";
            else if (timer == 0)
                return "Green";
            else if(timer == 30)
            {
                return "Orange";
            }
            return "Invalid";
        }
    }
}
