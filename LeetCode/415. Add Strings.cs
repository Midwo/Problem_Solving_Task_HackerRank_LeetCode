using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_415
    {
        ////(415.) Add Strings (EASY)
        public string AddStrings(string num1, string num2)
        {
            int howLongNum1 = num1.Length;
            int howLongNum2 = num2.Length;
            char[] num1Chars = num1.ToCharArray();
            char[] num2Chars = num2.ToCharArray();
            int addValue = 0;
            int currIndex = -1;
            if (howLongNum1 >= howLongNum2)
            {
                for (int i = howLongNum1-1; i >= 0; i--)
                {
                    currIndex++;
                    if (currIndex <= howLongNum2-1)
                    {
                        int tempValue = ((int)(num2[howLongNum2 - currIndex - 1]+addValue) +(int)num1[i]-48);
                        if (tempValue > 57)
                        {
                            addValue = 1;
                            num1Chars[i] = (char)(tempValue-10);
                        }
                        else
                        {
                            addValue = 0;
                            num1Chars[i] = (char)(tempValue);
                        }
                    }
                    else
                    {
                        int tempValue = (int)num1[i] + addValue;
                        if (tempValue > 57)
                        {
                            addValue = 1;
                            num1Chars[i] = (char)(tempValue - 10);
                        }
                        else
                        {
                            addValue = 0;
                            num1Chars[i] = (char)(tempValue);
                        }
                    }
                }
                if (addValue == 1)
                {
                    num1 = "1" + string.Join("", num1Chars);
                }
                else
                {
                    num1 = string.Join("", num1Chars);
                }
                return num1;
            }
            else
            {
                for (int i = howLongNum2 - 1; i >= 0; i--)
                {
                    currIndex++;
                    if (currIndex <= howLongNum1 - 1)
                    {
                        int tempValue = ((int)(num1[howLongNum1 - currIndex - 1] + addValue) + (int)num2[i] - 48);
                        if (tempValue > 57)
                        {
                            addValue = 1;
                            num2Chars[i] = (char)(tempValue - 10);
                        }
                        else
                        {
                            addValue = 0;
                            num2Chars[i] = (char)(tempValue);
                        }
                    }
                    else
                    {
                        int tempValue = (int)num2[i] + addValue;
                        if (tempValue > 57)
                        {
                            addValue = 1;
                            num2Chars[i] = (char)(tempValue - 10);
                        }
                        else
                        {
                            addValue = 0;
                            num2Chars[i] = (char)(tempValue);
                        }
                    }
                }
                if (addValue == 1)
                {
                    num2 = "1" + string.Join("", num2Chars);
                }
                else
                {
                    num2 = string.Join("", num2Chars);
                }
                return num2;
            }
        }
    }
}
