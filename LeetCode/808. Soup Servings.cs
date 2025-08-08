using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_808
    {
        ////(808.) Soup Servings (MEDIUM)

        private double[][] cache;
        public double SoupServings(int n)
        {
            if(n > 4800)
            {
                return 1;
            }
            else
            {
                cache = new double[192][];
                for (int i = 0; i < 192; i++) 
                {
                    cache[i] = new double[192];
                }

                return SoupServingsDFS((n + 24) / 25, (n + 24) / 25);
            }
        }

        private double SoupServingsDFS(int typeA, int typeB)
        {
            if (typeA <= 0 && typeB <= 0)
                return 0.5;
            if (typeA <= 0)
                return 1.0;
            if (typeB <= 0)
                return 0.0;
            if (cache[typeA][typeB] > 0)
                return cache[typeA][typeB];
            return cache[typeA][typeB] =
                       0.25 * (SoupServingsDFS(typeA - 4, typeB) + SoupServingsDFS(typeA - 3, typeB - 1) + 
                       SoupServingsDFS(typeA - 2, typeB - 2) + SoupServingsDFS(typeA - 1, typeB - 3));
        }

            //if (typeB > 0)
            //{
            //    if (typeA == 0 || typeA < 0)
            //    {
            //        //_countCorrectCases++;
            //        if(currLevelDeep > _howManyDeepLevels)
            //        {
            //            _countCorrectCases++;
            //        }
            //        else
            //        {
            //            _countCorrectCases += 4 * (Math.Pow(4, _howManyDeepLevels - currLevelDeep));
            //        }
            //        return;
            //    }
            //    else
            //    {
            //        CountCorrectCasesRecursion(typeA - 100, typeB, currLevelDeep + 1);
            //        CountCorrectCasesRecursion(typeA - 75, typeB - 25, currLevelDeep + 1);
            //        CountCorrectCasesRecursion(typeA - 50, typeB - 50, currLevelDeep + 1);
            //        CountCorrectCasesRecursion(typeA - 25, typeB - 75, currLevelDeep + 1);
            //    }
            //}
            //else
            //{
            //    if(typeA <= 0)
            //    {
            //        if (currLevelDeep > _howManyDeepLevels)
            //        {
            //            _countCorrectCases += 0.5;
            //        }
            //        else
            //        {
            //            _countCorrectCases += 2 * (Math.Pow(4, _howManyDeepLevels - currLevelDeep));
            //        }
            //        return;
            //    }
            //}

        }
    }

