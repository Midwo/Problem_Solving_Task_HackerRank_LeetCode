using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1432
    {
        ////(1432.) Max Difference You Can Get From Changing an Integer (MEDIUM)
        public int MaxDiff(int num)
        {
            string stringNum = num.ToString();
            string stringMin = string.Empty;
            string stringMax = string.Empty;
            char setToMAx = ' ';
            char setToMin = ' ';
            bool flagForMax = true;
            bool flagForMin = true;
            bool minToOne = false;
            bool lockOne = false;

            for (int i = 0; i < stringNum.Length; i++)
            {
                if (i == 0)
                {
                    if (stringNum[i] == '9')
                    {
                        stringMax += '9';
                    }
                    else
                    {
                        setToMAx = stringNum[i];
                        stringMax += '9';
                        flagForMax = false;
                    }

                    if (stringNum[i] == '1')
                    {
                        stringMin += '1';
                        lockOne = true;
                    }
                    else
                    {
                        setToMin = stringNum[i];
                        stringMin += '1';
                        flagForMin = false;
                        minToOne = true;
                    }
                }
                else
                {
                    if (flagForMax)
                    {
                        if (stringNum[i] == '9')
                        {
                            stringMax += '9';
                        }
                        else
                        {
                            setToMAx = stringNum[i];
                            stringMax += '9';
                            flagForMax = false;
                        }
                    }
                    else
                    {
                        if (stringNum[i] == '9')
                        {
                            stringMax += '9';
                        }
                        else if (stringNum[i] == setToMAx)
                        {
                            stringMax += '9';
                        }
                        else
                        {
                            stringMax += stringNum[i];
                        }
                    }

                    if (flagForMin)
                    {
                        if (stringNum[i] == '0')
                        {
                            stringMin += '0';
                        }
                        else
                        {
                            if (lockOne && stringNum[i] == '1')
                            {
                                stringMin += '1';
                            }
                            else
                            {
                                setToMin = stringNum[i];
                                stringMin += '0';
                                flagForMin = false;
                            }
                        }
                    }
                    else
                    {
                        if (stringNum[i] == '0')
                        {
                            stringMin += '0';
                        }
                        else if (stringNum[i] == setToMin)
                        {
                            if (minToOne)
                            {
                                stringMin += '1';
                            }
                            else
                            {
                                stringMin += "0";
                            }
                        }
                        else
                        {
                            stringMin += stringNum[i];
                        }
                    }
                }
            }
            return Convert.ToInt32(stringMax) - Convert.ToInt32(stringMin);
        }
    }
}
