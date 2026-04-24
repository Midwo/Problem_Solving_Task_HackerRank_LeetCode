using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_970
    {
        ////(970.) Powerful Integers (MEDIUM)
        public IList<int> PowerfulIntegers(int x, int y, int bound)
        {

            ////Solution 1 (Without Pruning, better memory, more readable code):
            var result = new HashSet<int>();

            var listValueX = new List<int>() { 1 };
            var listValueY = new List<int>() { 1 };

            int newValueWithPow = x;

            if (x > 1)
            {
                while (newValueWithPow < bound)
                {
                    listValueX.Add(newValueWithPow);
                    newValueWithPow *= x;
                }
            }

            newValueWithPow = y;

            if (y > 1)
            {
                while (newValueWithPow < bound)
                {
                    listValueY.Add(newValueWithPow);
                    newValueWithPow *= y;
                }
            }

            foreach (var a in listValueX)
                foreach (var b in listValueY)
                    if (a + b <= bound)
                        result.Add(a + b);

            return result.ToList();


            ////Solution 2 (with Pruning, 0 benefits):
            //var result = new HashSet<int>();

            //var listValueX = new List<int>() { 1 };
            //var listValueY = new List<int>() { 1 };

            //int newValueWithPow = x;

            //if (x > 1)
            //{
            //    while (newValueWithPow < bound)
            //    {
            //        listValueX.Add(newValueWithPow);
            //        newValueWithPow *= x;
            //    }
            //}

            //newValueWithPow = y;

            //if (y > 1)
            //{
            //    while (newValueWithPow < bound)
            //    {
            //        listValueY.Add(newValueWithPow);
            //        newValueWithPow *= y;
            //    }
            //}

            //foreach (var a in listValueX)
            //    foreach (var b in listValueY)
            //        if (a + b <= bound)
            //            result.Add(a + b);


            //int countPowX = listValueX.Count;
            //int countPowY = listValueY.Count;

            //int maxIndexY = countPowY - 1;

            //for (int i = 0; i < countPowX; i++)
            //{
            //    int currValueX = listValueX[i];

            //    for (int j = maxIndexY; j >= 0; j--)
            //    {
            //        int currValueYX = listValueY[j] + currValueX;
            //        if (currValueYX <= bound)
            //        {
            //            result.Add(currValueYX);
            //        }
            //        else
            //        {
            //            maxIndexY = j;
            //            break;
            //        }
            //    }
            //}

            //return result.ToList();
        }
    }
}
