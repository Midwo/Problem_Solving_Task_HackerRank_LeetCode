using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3842
    {
        ////(3842.) Toggle Light Bulbs (EASY)
        public IList<int> ToggleLightBulbs(IList<int> bulbs)
        {
            List<int> result = new List<int>();
            bool[] statusBulbs = new bool[101];

            foreach (int bulb in bulbs) 
            { 
                statusBulbs[bulb] = !statusBulbs[bulb];
            }

            for(int index = 1; index < 101; index++)
            {
                if (statusBulbs[index])
                    result.Add(index);
            }

            return result;
        }
    }
}
