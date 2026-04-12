using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0069
    {
        ////69. Lonely Integer (EASY)
        public int lonelyinteger(List<int> a)
        {
            Dictionary<int, int> howManyNumber = new Dictionary<int, int>();
            int minimumValueReplay = int.MaxValue;
            int minimumKeyReplay = 0;

            foreach (int i in a)
            {
                if (howManyNumber.ContainsKey(i))
                {
                    howManyNumber[i]++;
                }
                else
                {
                    howManyNumber.Add(i, 1);
                }
            }

            foreach (var i in howManyNumber)
            {
                if (i.Value < minimumValueReplay)
                {
                    minimumValueReplay = i.Value;
                    minimumKeyReplay = i.Key;
                }
            }

            return minimumKeyReplay;
        }

    }
}

