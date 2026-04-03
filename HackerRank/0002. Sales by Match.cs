using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0002
    {
        public int sockMerchant(int n, List<int> ar)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            foreach (int i in ar)
            {
                if (!dictionary.ContainsKey(i))
                {
                    dictionary.Add(i, 1);
                }
                else
                {
                    int x = dictionary[i] + 1;
                    dictionary[i] = x;
                }
            }
            int howManyPairs = 0;
            double y1 = 0;
            foreach (var x in dictionary.Values)
            {
                if (x >= 2)
                {
                    y1 = x / 2;
                    howManyPairs += (int)y1;
                }
            }
            return howManyPairs;
        }

    }
}
