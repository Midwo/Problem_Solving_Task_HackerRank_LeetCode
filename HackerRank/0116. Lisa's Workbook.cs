using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0116
    {
        ////116. Lisa's Workbook (EASY)
        public int workbook(int n, int k, List<int> arr)
        {
            ///Solution 1 (New)
            int page = 0;
            int countSpecialProblems = 0;
            foreach (var number in arr)
            {
                page++;
                for (int currProblem = 1; currProblem <= number; currProblem++)
                {
                    if (currProblem == page)
                        countSpecialProblems++;
                    if (currProblem % k == 0 && currProblem < number)
                        page++;
                }
            }

            return countSpecialProblems;

            ////Solution 2 (Old)
            //int howManySpecial = 0;
            //int pageMain = 0;
            //int counter = 0;

            //for (int i = 1; i <= n; i++)
            //{
            //    pageMain++;
            //    counter = 0;
            //    for (int x = 1; x <= arr[i - 1]; x++)
            //    {
            //        counter++;
            //        if (counter > k)
            //        {
            //            pageMain++;
            //            counter = 1;
            //        }
            //        if (pageMain == x)
            //        {
            //            howManySpecial++;
            //        }
            //    }
            //}
            //return howManySpecial;
        }

    }
}
