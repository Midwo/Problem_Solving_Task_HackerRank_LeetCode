using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2119
    {
        ////(2119.) A Number After a Double Reversal (EASY)
        public bool IsSameAfterReversals(int num)
        {
            ////Option 1
            
            if (num > 0 && num % 10 != 0)
            {
                return true;
            }
            else if (num > 0 && num % 10 == 0)
            {
                return false;
            }
            return true;

            ////Option 2
            //string charsNum = num.ToString();
            //if (charsNum.Length == 1)
            //{
            //    return true;
            //}

            //if (charsNum[charsNum.Length-1] == '0')
            //{
            //    return false;
            //}

            //return true;

            ////Option 3
            //string resultString = string.Empty;
            //int copyNum = num;
            //if (num == 0)
            //{
            //    return true;
            //}
            //while(copyNum != 0)
            //{
            //    int temp = copyNum % 10;
            //    if (temp > 0)
            //    {
            //        resultString += temp;
            //    }
            //    else if( resultString.Length > 0)
            //    {
            //        resultString += temp;
            //    }
            //    copyNum /= 10;
            //}

            //resultString = new string(resultString.Reverse().ToArray());
            //return int.Parse(resultString) == num; 
        }
    }
}
