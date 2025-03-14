using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_12
    {
        ////(12.) Integer to Roman (MEDIUM)
        public string IntToRoman(int num)
        {
            string[] thousands = ["", "M", "MM", "MMM"];
            string[] hundreds = ["", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"];
            string[] tens = ["", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"];
            string[] units = ["", "I", "II","III","IV","V","VI", "VII", "VIII", "IX"];

            return thousands[num / 1000] + hundreds[num % 1000 / 100] + tens[num%100/10] + units[num%10];

            ///SLOW Version 

            //char[] chars = ['I', 'V', 'X', 'L', 'C', 'D', 'M'];
            //int x = 5;
            //int transitionIndex = 0;
            //StringBuilder sb = new StringBuilder();

            //while (num != 0)
            //{
            //    int rest = num % 10;
            //    num = (num - rest) / 10;

            //    switch (rest)
            //    {
            //        case 0:
            //            break;
            //        case 1:
            //            sb.Append(chars[0 + transitionIndex]);
            //            break;
            //        case 2:
            //            sb.Append(chars[0 + transitionIndex]); sb.Append(chars[0 + transitionIndex]);
            //            break;
            //        case 3:
            //            sb.Append(chars[0 + transitionIndex]); sb.Append(chars[0 + transitionIndex]); sb.Append(chars[0 + transitionIndex]);
            //            break;
            //        case 4:
            //            sb.Append(chars[1 + transitionIndex]); sb.Append(chars[0 + transitionIndex]);
            //            break;
            //        case 5:
            //            sb.Append(chars[1 + transitionIndex]);
            //            break;
            //        case 6:
            //            sb.Append(chars[0 + transitionIndex]); sb.Append(chars[1 + transitionIndex]);
            //            break;
            //        case 7:
            //            sb.Append(chars[0 + transitionIndex]); sb.Append(chars[0 + transitionIndex]); sb.Append(chars[1 + transitionIndex]);
            //            break;
            //        case 8:
            //            sb.Append(chars[0 + transitionIndex]); sb.Append(chars[0 + transitionIndex]); sb.Append(chars[0 + transitionIndex]); sb.Append(chars[1 + transitionIndex]);
            //            break;
            //        case 9:
            //            sb.Append(chars[2 + transitionIndex]); sb.Append(chars[0 + transitionIndex]);
            //            break;
            //    }
            //    transitionIndex += 2;
            //}
            //return new string(sb.ToString().Reverse().ToArray());
        }
    }
}
