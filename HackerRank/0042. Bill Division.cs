using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0042
    {
        ////42. Bill Division (EASY)
        public void bonAppetit(List<int> bill, int k, int b)
        {
            int sum1 = 0;
            for (int i = 0; i < bill.Count; i++)
            {
                if (i != k)
                {
                    sum1 += bill[i];
                }
            }
            sum1 = b - (sum1 / 2);

            if (sum1 == 0)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(sum1);
            }
        }
    }
}
