using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2810
    {
        ////(2810.) Faulty Keyboard (EASY)
        public string FinalString(string s)
        {
            ////Solution #1
            ////2ms, Beats: 100.00%

            List<char> listChars = new List<char>();

            foreach (char c in s)
            {
                if (c == 'i')
                {
                    listChars.Reverse();
                }
                else
                {
                    listChars.Add(c);
                }
            }

            return new string(listChars.ToArray()); 
                
            ////Solution #2
            ////7ms, Beats: 33.33%
            //StringBuilder sb = new StringBuilder();

            //foreach (char c in s)
            //{
            //    if (c == 'i')
            //    {
            //        StringBuilder temp = new StringBuilder();

            //        for (int i = sb.Length - 1; i >= 0; i--)
            //        {
            //            temp.Append(sb[i]);
            //        }

            //        sb = temp;
            //    }
            //    else
            //    {
            //        sb.Append(c);
            //    }
            //}


            //return sb.ToString();
        }
    }
}
