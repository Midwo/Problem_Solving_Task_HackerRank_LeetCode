using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0071
    {
        ////71. Jim and the Orders (EASY)   
        public List<int> jimOrders(List<List<int>> orders)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            for (int i = 0; i < orders.Count; i++)
            {
                dictionary.Add(i + 1, (orders[i][0] + orders[i][1]));
            }

            List<int> jimOrdersList = dictionary.OrderBy(x => x.Value).Select(x => x.Key).ToList();

            return jimOrdersList;
        }
    }
}
