using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2260
    {
        ////(2260.) Minimum Consecutive Cards to Pick Up (MEDIUM)
        public int MinimumCardPickup(int[] cards)
        {
            Dictionary<int, int> lastIndexValue = new Dictionary<int, int>();
            int minLenght = int.MaxValue;

            for (int index = 0; index < cards.Length; index++) 
            { 
                int value = cards[index];

                if (lastIndexValue.ContainsKey(value))
                {
                    minLenght = Math.Min(index - lastIndexValue[value]+1, minLenght);
                    lastIndexValue[value] = index;
                }
                else
                {
                    lastIndexValue.Add(value, index);
                }

            }

            return minLenght == int.MaxValue? -1 : minLenght;
        }
    }
}
