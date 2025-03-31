using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_605
    {
        ////(605.) Can Place Flowers (EASY)
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            bool firstEmpty = flowerbed[0] == 0? true : false;
            int emptyDistance = 0;
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 1)
                {
                    if (firstEmpty)
                    {
                        n -= emptyDistance / 2;
                        emptyDistance = 0;
                        firstEmpty = false;
                    }
                    else
                    {
                        if(emptyDistance >= 3)
                        {
                            while(emptyDistance >= 3)
                            {
                                --n;
                                emptyDistance -= 2;
                            }
                            //n -= emptyDistance / 3;                       
                        }
                        emptyDistance = 0;
                    }
                }
                else
                {
                    emptyDistance++;
                    if (i >= 1 && firstEmpty)
                    {
                        emptyDistance = 1;
                        --n;
                        firstEmpty = false;
                    }
                }
                if (n <= 0)
                {
                    return true;
                }
            }
            if (emptyDistance > 0 && firstEmpty)
            {
                if (flowerbed.Length == 1)
                {
                    return true;
                }
            }
            if (emptyDistance >= 2)
            {
                n -= emptyDistance / 2;
                if (n <= 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
