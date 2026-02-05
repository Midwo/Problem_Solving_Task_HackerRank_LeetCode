using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1837
    {
        ////(1837.) Sum of Digits in Base K (EASY)
        public int SumBase(int n, int k)
        {
            //Solution 1

            int sum = 0;
            while (n > 0) 
            { 
                sum += n % k; 
                n /= k; 
            }
            return sum;


            //Solution 2

            //int sumDigits = 0;
            //List<int> intsKMinPow = new List<int>();
            //int currValue = 1;
            //int currPow = 0;
            //while(currValue <= n)
            //{
            //    currValue = (int)Math.Pow(k, currPow++);
            //    intsKMinPow.Add(currValue);
            //} 

            //int indexlenghtIntsKMinPow = intsKMinPow.Count -1;
            //while(n > 0)
            //{
            //    if(n >= intsKMinPow[indexlenghtIntsKMinPow])
            //    {
            //        int count = n / intsKMinPow[indexlenghtIntsKMinPow];
            //        sumDigits += count;
            //        n -= count * (int)Math.Pow(k, indexlenghtIntsKMinPow);
            //    }
            //    indexlenghtIntsKMinPow--;
            //}

            //return sumDigits;
        }
    }
}
