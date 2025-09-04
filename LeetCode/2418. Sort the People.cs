using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2418
    {
        ////(2418.) Sort the People (EASY)
        public string[] SortPeople(string[] names, int[] heights)
        {
            Array.Sort(heights, names);

            return names.Reverse().ToArray();
        }
    }
}
