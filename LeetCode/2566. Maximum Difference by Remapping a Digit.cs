using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2566
    {
        ////(2566.) Maximum Difference by Remapping a Digit (EASY)
        public int MinMaxDifference(int num)
        {
            string stringNum = num.ToString();
            string stringMin = string.Empty;
            string stringMax = string.Empty;
            char setToMAx = ' ';
            char setToMin = ' ';

            for (int i = 0; i < stringNum.Length; i++)
            {
                if (stringNum[i] != '9')
                {
                    if (setToMAx == ' ')
                    {
                        setToMAx = stringNum[i];
                    }
                    if (stringNum[i] == setToMAx)
                    {
                        stringMax += '9';
                    }
                    else
                    {
                        stringMax += stringNum[i];
                    }
                }
                else
                {
                    stringMax += '9';
                }

                if (stringNum[i] != '0')
                {
                    if (setToMin == ' ')
                    {
                        setToMin = stringNum[i];
                    }
                    if (stringNum[i] == setToMin)
                    {
                        stringMin += 0;
                    }
                    else
                    {
                        stringMin += stringNum[i];
                    }
                }
                else
                {
                    if (setToMin != ' ')
                    {
                        stringMin += stringNum[i];
                    }
                }
            }

            return Convert.ToInt32(stringMax) - Convert.ToInt32(stringMin);
        }
    }
}
