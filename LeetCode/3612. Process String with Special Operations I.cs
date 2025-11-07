using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3612
    {
        ////(3612.) Process String with Special Operations I (MEDIUM)
        public string ProcessStr(string s)
        {
            ////Solution #1
            ////4ms, Beats: 100.00%
            
            StringBuilder sb = new StringBuilder();

            foreach (char item in s) 
            {
                if (item == '#')
                {
                    sb.Append(sb);
                }
                else if (item == '%')
                {
                    StringBuilder temp = new StringBuilder();

                    for (int i = sb.Length-1; i >= 0; i--) 
                    {
                        temp.Append(sb[i]);
                    }

                    sb = temp;
                }
                else if (item == '*')
                {
                    if (sb.Length > 0)
                    {
                        sb.Remove(sb.Length - 1, 1);
                    }
                }
                else
                {
                    sb.Append(item);
                }
            }

            return sb.ToString();


            ////Solution #2
            ////7ms, Beats: 66.67%
            
            //List<char> listChar = new List<char>();

            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (s[i] == '#')
            //    {
            //        listChar.AddRange(listChar);
            //    }
            //    else if (s[i] == '%')
            //    {
            //        listChar.Reverse();
            //    }
            //    else if (s[i] == '*')
            //    {
            //        if(listChar.Count > 0)
            //        {
            //            listChar.RemoveAt(listChar.Count-1);
            //        }
            //    }
            //    else
            //    {
            //        listChar.Add(s[i]);
            //    }
            //}

            //return new string(listChar.ToArray());
        }
    }
}
