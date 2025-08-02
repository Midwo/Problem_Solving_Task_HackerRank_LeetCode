using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2561
    {
        ////(2561.) Rearranging Fruits (HARD)
        public long MinCost(int[] basket1, int[] basket2)
        {
            Dictionary<int, int> dictionaryBasket = new Dictionary<int, int>();
            int length = basket1.Length;

            for (int i = 0; i < length; i++)
            {
                if (!dictionaryBasket.TryAdd(basket1[i], 1))
                {
                    dictionaryBasket[basket1[i]]++;
                }
                if (!dictionaryBasket.TryAdd(basket2[i], -1))
                {
                    dictionaryBasket[basket2[i]]--;
                }
            }

            List<int> fruitDifferencesList = new List<int>();
            int minFruitValue = int.MaxValue;


            foreach (var item in dictionaryBasket)
            {
                if (item.Value % 2 != 0)
                {
                    return -1;
                }

                for (int i = 0; i < Math.Abs(item.Value) / 2; i++)
                {
                    fruitDifferencesList.Add(item.Key);
                }

                minFruitValue = Math.Min(item.Key, minFruitValue);
            }

            fruitDifferencesList.Sort();

            long resultCost = 0;

            for (int i = 0; i < fruitDifferencesList.Count / 2; i++)
            {
                resultCost += Math.Min(fruitDifferencesList[i], minFruitValue * 2);
            }

            return resultCost;

        }
    }
}
