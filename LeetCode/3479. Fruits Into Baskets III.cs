using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3479
    {
        ////(3479.) Fruits Into Baskets III (MEDIUM)
        public int NumOfUnplacedFruits(int[] fruits, int[] baskets)
        {
            int length = fruits.Length;
            int result = length;
            int lengthBaskets = baskets.Length;

            int indexBaskets = 0;
            int currFruit = fruits[0];

            if (length < 100)
            {
                for (int i = 0; i < fruits.Length; i++)
                {
                    currFruit = fruits[i];
                    indexBaskets = 0;
                    while (indexBaskets < lengthBaskets)
                    {
                        if (currFruit <= baskets[indexBaskets])
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
            else
            {
                bool systematicGrowBaskets = true;
                bool systematicLessBaskets = true;
                bool theSame = true;

                int lastBasketValue = -1;
                int diffBasket = Math.Abs(baskets[0] - baskets[1]);
                bool diffBasketStatic = true;

                while (indexBaskets < lengthBaskets)
                {
                    if (lastBasketValue >= baskets[indexBaskets])
                    {
                        if (lastBasketValue != baskets[indexBaskets])
                        {
                            theSame = false;
                        }
                        systematicGrowBaskets = false;
                    }
                    else
                    {
                        systematicLessBaskets = false;
                    }

                    if (currFruit <= baskets[indexBaskets])
                    {
                        result--;
                        baskets[indexBaskets] = -1;
                        break;
                    }
                    else
                    {
                        indexBaskets++;
                    }
                    if (indexBaskets > 1 && diffBasketStatic)
                    {
                        if (diffBasket != Math.Abs(baskets[indexBaskets] - baskets[indexBaskets - 1]))
                        {
                            diffBasketStatic = false;
                        }
                    }
                }

                if (indexBaskets == length - 1 && diffBasketStatic)
                {
                    if (systematicGrowBaskets && baskets.Length == length)
                    {
                        return 0;
                    }
                    else if (systematicLessBaskets && baskets.Length == length)
                    {
                        return 0;
                    }
                }

                for (int i = 1; i < fruits.Length; i++)
                {
                    if (currFruit > fruits[i])
                    {
                        indexBaskets = 0;
                    }

                    currFruit = fruits[i];

                    while (indexBaskets < lengthBaskets)
                    {
                        if (currFruit <= baskets[indexBaskets])
                        {
                            result--;
                            baskets[indexBaskets] = -1;
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
}
