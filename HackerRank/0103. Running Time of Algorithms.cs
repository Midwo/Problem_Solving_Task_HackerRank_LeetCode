using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0103
    {
        ////103. Running Time of Algorithms (EASY)
        public  int runningTime(List<int> arr)
        {
            var countShifts = 0;

            for (int index = 1; index < arr.Count; index++)
            {
                var currValue = arr[index];
                for (int j = 0; j < index; j++)
                {
                    if (currValue < arr[j])
                    {
                        countShifts++;
                    }
                }
            }
            return countShifts++;
        }
    }
}
