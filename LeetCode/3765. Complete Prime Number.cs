using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3765
    {
        ////(3765.) Complete Prime Number (MEDIUM)
        public bool CompletePrime(int num)
        {
            string numString = num.ToString();
            int length = numString.Length;
            if (num == 1)
            {
                return false;
            }
            for(int index = 0; index < length; index++)
            {
                if (!statusPrime(int.Parse(numString[0..(index+1)])))
                {
                    return false;
                }
            }
            for (int index = 1; index < length; index++)
            {
                if (!statusPrime(int.Parse(numString[index..length])))
                {
                    return false;
                }
            }
            return true;
        }

        private bool statusPrime(int value)
        {
            if(value == 1)
            {
                return false;
            }
            else if (value <= 3)
            {
                return true;
            }
            bool status = true;

            for (int currValue = 2; currValue <= Math.Sqrt(value); currValue++) 
            { 
                if(value % currValue == 0)
                {
                    return false;
                }
            }

            return status;
        }
    }
}
