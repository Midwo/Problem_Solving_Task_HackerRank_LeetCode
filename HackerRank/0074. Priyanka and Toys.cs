using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0074
    {
        ////74. Priyanka and Toys (EASY)
        public int toys(List<int> w)
        {
            w.Sort();
            int startWeight = w[0];
            int howManyConteiner = 1;

            foreach (int i in w)
            {
                if (startWeight + 4 < i)
                {
                    howManyConteiner++;
                    startWeight = i;
                }
            }
            return howManyConteiner;
        }

    }
}

