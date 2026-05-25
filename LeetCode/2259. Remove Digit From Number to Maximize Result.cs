using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2259
    {
        ////(2259.) Remove Digit From Number to Maximize Result (EASY)
        public string RemoveDigit(string number, char digit)
        {
            ////Solution 1

            int length = number.Length;
            string maxNumberString = string.Empty;

            for (int index = 0; index < length; index++)
            {
                if (number[index] == digit)
                {
                    string currString = number[0..index] + number[(index + 1)..length];

                    maxNumberString = string.CompareOrdinal(currString, maxNumberString) > 0 ? currString : maxNumberString;
                }
            }

            return maxNumberString;


            //Solution 2

            //int length = number.Length;
            //string maxNumber = new string('0', length-1);

            //for (int index = 0; index < length; index++)
            //{
            //    if (number[index] == digit)
            //    {
            //        string currString = number[0..index] + number [(index+1)..length];

            //        for (int i = 0; i < length-1; i++)
            //        {
            //            if (maxNumber[i] < number[i])
            //            {
            //                maxNumber = currString;
            //            }
            //            else if (maxNumber[i] > number[i])
            //            {
            //                break;
            //            }
            //        }
            //    }
            //}

            //return maxNumber;
        }
    }
}
