using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3751
    {
        ////(3751.) Total Waviness of Numbers in Range I (MEDIUM)
        public int TotalWaviness(int num1, int num2)
        {
            ////Solution 1

            int sumWaviness = 0;

            for (int currValue = num1; currValue <= num2; currValue++)
            {
                int countWaviness = 0;
                int copyCurrValue = currValue;

                if (currValue > 100) {
                    int next = copyCurrValue % 10;
                    copyCurrValue /= 10;
                    int mid = copyCurrValue % 10;
                    copyCurrValue /= 10;
                    int prev = copyCurrValue % 10;
                    copyCurrValue /= 10;

                    if (mid > next && mid > prev)
                        countWaviness++;
                    else if (mid < next && mid < prev)
                        countWaviness++;

                    
                    while (copyCurrValue != 0)
                    {
                        next = mid;
                        mid = prev;
                        prev = copyCurrValue % 10;
                        copyCurrValue /= 10;

                        if (mid > next && mid > prev)
                            countWaviness++;
                        else if (mid < next && mid < prev)
                            countWaviness++;
                    }

                    sumWaviness += countWaviness;
                } 
            }

            return sumWaviness;


            ////Slution 2
            //int sumWaviness = 0;

            //for (int currValue = num1; currValue <= num2; currValue++)
            //{
            //    int countWaviness = 0;
            //    string currValueToString =  currValue.ToString();

            //    for (int index = 1; index < currValueToString.Length-1; index++)
            //    {
            //        char currchar = currValueToString[index];
            //        char prevChar = currValueToString[index - 1];
            //        char nextChar = currValueToString[index + 1];

            //        if(currchar > prevChar && currchar > nextChar)
            //            countWaviness++;
            //        else if (currchar < prevChar && currchar < nextChar)
            //            countWaviness++;
            //    }

            //    sumWaviness += countWaviness;
            //}

            //return sumWaviness;
        }
    }
}
