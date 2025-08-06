using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3477
    {
        ////(3477.) Fruits Into Baskets II (EASY)
        public int NumOfUnplacedFruits(int[] fruits, int[] baskets)
        {
            int result = fruits.Length;
            int lengthBaskets = baskets.Length;

            int indexBaskets = 0;
            int currFruit = 0;

            for (int i = 0; i < fruits.Length; i++)
            {
                currFruit = fruits[i];
                indexBaskets = 0;
                while (indexBaskets < lengthBaskets)
                {
                    if(currFruit <= baskets[indexBaskets])
                    {
                        result--;
                        baskets[indexBaskets] = int.MinValue;
                        break;
                    }
                    else
                    {
                        indexBaskets++;
                    }
                }

            }

            return result;
        }
    }
}
