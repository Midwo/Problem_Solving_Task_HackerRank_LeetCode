using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2696
    {
        ////(2696.) Minimum String Length After Removing Substrings (EASY)
        public int MinLength(string s)
        {
            ////Solution #1
            ////3ms, Beats: 85.71%
            
            while(s.Contains("AB") || s.Contains("CD"))
            {
                s = s.Replace("AB","");
                s = s.Replace("CD","");
            }

            return s.Length;

            ////Solution #2
            ////10ms, Beats: 14.29%
            
            //StringBuilder sb = new StringBuilder(s);
            //bool status = false;
            
            //while (!status)
            //{
            //    status = true;

            //    for (int i = 0; i < sb.Length-1; i++) 
            //    {
            //        if (sb[i] == 'A' && sb[i+1] == 'B' || sb[i] == 'C' && sb[i+1] == 'D')
            //        {
            //            status = false;
            //            sb.Remove(i, 2);
            //            break;
            //        }
            //    }
            //}

            //return sb.Length;
        }
    }
}
