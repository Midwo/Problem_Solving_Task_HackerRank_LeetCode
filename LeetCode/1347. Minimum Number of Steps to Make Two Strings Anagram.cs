using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1347
    {
        ////(1347.) Minimum Number of Steps to Make Two Strings Anagram ()
        public int MinSteps(string s, string t)
        {
            ////2ms, Beats: 98.08%

            int count = 0;
            int[] intsS = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                intsS[s[i] - 'a']++;
                intsS[t[i] - 'a']--;
            }

            for (int i = 0; i < intsS.Length; i++)
            {
                //Console.WriteLine((char)(intsS[i] + 'a'));
                if (intsS[i] < 0)
                {
                    count += Math.Abs(intsS[i]);
                }

            }

            return count;



            //// 4ms, Beats: 51.92%

            //int count = 0;
            //int[] intsS = new int[26];
            //int[] intsT = new int[26];

            //for (int i = 0; i < s.Length; i++)
            //{
            //    intsS[s[i] - 'a']++;
            //}
            //for (int i = 0; i < s.Length; i++)
            //{
            //    intsT[t[i] - 'a']++;
            //}

            //for (int i = 0; i < intsS.Length; i++)
            //{
            //    //Console.WriteLine((char)(intsS[i] + 'a'));
            //    if (intsS[i] > intsT[i])
            //    {
            //        count += intsS[i] - intsT[i];
            //    }

            //}

            //return count;
        }
    }
}
