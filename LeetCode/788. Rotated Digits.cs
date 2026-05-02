using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_788
    {
        ////(788.) Rotated Digits (MEDIUM)
        public int RotatedDigits(int n)
        {
            ////Solution 1 (Better)
            int countGoodNumber = 0;

            for (int number = 1; number <= n; number++)
            {
                bool status = false;
                int currNumber = number;
                while(currNumber > 0)
                {
                    int temp = currNumber % 10;

                    if (temp == 6 || temp == 9 || temp == 2 || temp == 5)
                    {
                        status = true;
                    }
                    if (temp == 3 || temp == 7 || temp == 4)
                    {
                        status = false;
                        break;
                    }
                    currNumber /= 10;
                }

                if (status)
                    countGoodNumber++;
            }

            return countGoodNumber;


            ////Solution 2 (Poor)
            //int countGoodNumber = 0;
            //var tableChange = new char[10] {'0', '1', '5', 'x', 'x', '2', '9', 'x', '8', '6'};

            //for (int number = 1; number <= n; number++)
            //{
            //    string stringNumber = number.ToString();
            //    string newString = string.Empty;
            //    bool status = true;
            //    for (int index = 0; index < stringNumber.Length; index++)
            //    {
            //        //Console.WriteLine(stringNumber[index]);
            //        //Console.WriteLine(tableChange[(int)(stringNumber[index] -'0')]);
            //        char newChar = tableChange[(int)(stringNumber[index] - '0')];
            //        if (newChar == 'x')
            //        {
            //            status = false;
            //            break;
            //        }
            //        else
            //        {
            //            newString += newChar;
            //        }
            //    }
            //    if (status && stringNumber != newString)
            //        countGoodNumber++;
            //}

            //return countGoodNumber;
        }
    }
}
