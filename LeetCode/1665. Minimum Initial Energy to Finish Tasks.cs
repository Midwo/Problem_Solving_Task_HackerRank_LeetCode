using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1665
    {
        ////(1665.) Minimum Initial Energy to Finish Tasks (HARD)
        public int MinimumEffort(int[][] tasks)
        {
            tasks = tasks.OrderBy(x => (x[0] - x[1])).ToArray();

            int minEnergyStart = 0;
            int currEnergy = 0;

            foreach (var task in tasks)
            {
                if(currEnergy < task[1])
                {
                    minEnergyStart += task[1] - currEnergy;
                    currEnergy = task[1];
                }

                currEnergy -= task[0];

            }

            return minEnergyStart;
        }
    }
}
