using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0078
    {
        ////78. Luck Balance (EASY)     
        public int luckBalance(int k, List<List<int>> contests)
        {
            List<int> important = new List<int>();
            int luck = 0;

            foreach (var item in contests)
            {
                if (item[1] == 1)
                {
                    important.Add(item[0]);
                }
                else
                {
                    luck += item[0];
                }
            }

            important = important.OrderByDescending(x => x).ToList();

            luck += important.Take(k).Sum();
            luck -= important.Skip(k).Sum();

            return luck;

        }
    }
}
