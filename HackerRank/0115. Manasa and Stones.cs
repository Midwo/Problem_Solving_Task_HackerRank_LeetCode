using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0115
    {
        ////115. Manasa and Stones (EASY)
        public List<int> stones(int n, int a, int b)
        {
            ////Solution 1 (New - Better)
            var uniqueLastValue = new HashSet<int>();

            if (a > b)
            {
                int temp = b;
                b = a;
                a = temp;
            }
            for (int i = 0; i < n; i++)
            {
                uniqueLastValue.Add(a * (n - i -1) + b * i);
            }

            return uniqueLastValue.ToList();


            ////Solution 2 (Old - Poor)
            //List<int> outPrintList = new List<int>();

            //for (int i = 0; i < n; i++)
            //{
            //    int x = (n - i - 1) * a + (i * b);
            //    if (!outPrintList.Contains(x))
            //    {
            //        outPrintList.Add(x);
            //    }
            //}
            //outPrintList.Sort();
            //return outPrintList;
        }
    }
}
