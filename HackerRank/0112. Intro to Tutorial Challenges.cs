using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0112
    {
        ////112. Intro to Tutorial Challenges (EASY)
        public int introTutorial(int V, List<int> arr)
        {
            ////Solution 1 (New - Better)
            for (int i = 0; i < arr.Count; i++)
            {
                if (V == arr[i])
                    return i;
            }
            return -1;

            ////Solution 2 (Old - Poor)
            ////Kept for reference. This version relied on counting elements smaller than V,
            ////which only works accidentally for sorted arrays and does NOT solve the actual problem.
            ////Left here as an example of flawed reasoning before refactoring.
            
            //int howMany = 0;
            //foreach (int i in arr)
            //{
            //    howMany = V > i ? ++howMany : howMany;
            //}
            //return howMany;
        }
    }
}
