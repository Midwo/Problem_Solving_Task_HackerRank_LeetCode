using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1175
    {
        ////(1175.) Prime Arrangements (EASY)
        public int NumPrimeArrangements(int n)
        {
            int[] primesNumbers = [2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97];
            int howManyPrimeNumbers = 0;
            ulong combinationPrime = 0;
            ulong combinationNoPrime = 0;
            ulong mod = 1000000007;
            if (n == 1)
            {
                return 0;
            }
            if (n >= 97)
            {
                howManyPrimeNumbers = 25;
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (primesNumbers[i] <= n)
                    {
                        howManyPrimeNumbers++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            int howManyNoPrimeNumbers = n - howManyPrimeNumbers;

            while (howManyPrimeNumbers != 0)
            {
                if (combinationPrime == 0)
                {
                    combinationPrime = (ulong)howManyPrimeNumbers;
                }
                else
                {
                    combinationPrime = (combinationPrime * (ulong)howManyPrimeNumbers) % mod;
                }
                howManyPrimeNumbers--;
            }

            while (howManyNoPrimeNumbers != 0)
            {
                if (combinationNoPrime == 0)
                {
                    combinationNoPrime = (ulong)howManyNoPrimeNumbers;
                }
                else
                {
                    combinationNoPrime = (combinationNoPrime * (ulong)howManyNoPrimeNumbers) % mod;
                }
                howManyNoPrimeNumbers--;
            }

            ulong result = ((ulong)combinationNoPrime * (ulong)combinationPrime) % mod;
            return (int)result;
        }
    }
}
