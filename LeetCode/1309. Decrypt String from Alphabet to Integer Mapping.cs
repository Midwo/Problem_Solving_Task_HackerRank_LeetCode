
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1309
    {
        ////(1309.) Decrypt String from Alphabet to Integer Mapping (EASY)
        public string FreqAlphabets(string s)
        {
            StringBuilder sb = new StringBuilder();

            int tempValue = 0;
            for (int i = 0; i < s.Length; i++) 
            {
                if (i+2 < s.Length && s[i+2] == '#')
                {
                    tempValue = (s[i] - '0') * 10 + s[i + 1] - '0';
                    sb.Append(Convert.ToChar(tempValue + 96));
                    i += 2;
                }
                else
                {
                    sb.Append(Convert.ToChar(s[i] + 48));
                }
            }
            

            return sb.ToString();




            //List<char> listChars = new List<char>();

            //int tempValue = 0;
            //for (int i = s.Length-1; i >= 0; i--) 
            //{ 
            //    if (s[i] == '#')
            //    {
            //        tempValue = Convert.ToInt32(s[i - 2].ToString() + s[i - 1].ToString());
            //        listChars.Add(Convert.ToChar(tempValue + 96));
            //        i -= 2;
            //    }
            //    else
            //    {
            //        listChars.Add(Convert.ToChar(s[i] + 48));
            //    }            
            //}

            //listChars.Reverse();
            //return string.Concat(listChars);
        }
    }
}
