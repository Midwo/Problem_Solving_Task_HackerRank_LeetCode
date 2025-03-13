using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_8
    {
        ////(8.) String to Integer (atoi) (MEDIUM)
        public int MyAtoi(string s)
        {
            int quantityToSkip = 0;
            int sLength = s.Length;
            StringBuilder sb = new StringBuilder();
            bool zeroBeforeValue = true;
            bool signBeforeValue = false;
            bool returnZero = false;
            for (int i = 0; i < sLength; i++)
            {
                if (s[i] == ' ')
                {
                    quantityToSkip++;
                }
                else
                {
                    break;
                }
            }
            if (quantityToSkip < sLength - 1)
            {
                if (s[quantityToSkip] == '-')
                {
                    sb.Append('-');
                    signBeforeValue = true;
                    quantityToSkip++;
                }
                else if (s[quantityToSkip] == '+') 
                {
                    signBeforeValue = true;
                    quantityToSkip++;
                }
            }
            for (int i = quantityToSkip; i < sLength; i++)
            {
                if ((int)s[i] >= 48 && (int)s[i] <= 57)
                {
                    if (zeroBeforeValue)
                    {
                        if ((int)s[i] > 48)
                        {
                            sb.Append(s[i]);
                            zeroBeforeValue = false;
                        }
                    }
                    else
                    {
                        sb.Append(s[i]);
                    }
                }
                else
                {
                    break;
                }
            }
            if (sb.Length < 2)
            {
                if (sb.Length == 0)
                {
                    return 0;
                }
                else if ((int)sb[0] < 48 || (int)sb[0] > 57)
                {
                    return 0;
                }
                return (int)Char.GetNumericValue(sb[0]);
            }
            if (sb.Length > 11) 
            {
                if (sb[0] == '-') 
                {
                    return Int32.MinValue;
                }
                else
                {
                    return Int32.MaxValue;
                }
            }
            long resultLong = Convert.ToInt64(sb.ToString());
            if (resultLong > Int32.MaxValue)
            {
                resultLong = Int32.MaxValue;
            }
            else if (resultLong < Int32.MinValue)
            {
                resultLong = Int32.MinValue;
            }
            return (int)resultLong;
        }
    }
}
