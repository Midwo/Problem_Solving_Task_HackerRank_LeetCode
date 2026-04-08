using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0033
    {
        ////33. Staircase (EASY)        
        public void staircase(int n)
        {
            string space = "";
            string hash = "";
            string all = "";
            for (int i = 0; i < n; i++)
            {
                space = "";
                int hashspace = n - i;
                if (hashspace > 1)
                {
                    for (int z = 1; z < hashspace; z++)
                    {
                        space += " ";
                    }
                }

                hash += "#";
                all = space + hash;
                Console.WriteLine(all);

            }
        }
    }
}
