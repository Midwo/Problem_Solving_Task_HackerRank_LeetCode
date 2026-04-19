using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0102
    {
        ////102. HackerRank in a String! (EASY)
        public string hackerrankInString(string s)
        {
            ////Solution 1 (New - Better)
            var targetCharsTable = new char[] {'h', 'a', 'c', 'k', 'e', 'r', 'r', 'a', 'n', 'k'};
            var indexTarget = 0;
            var seachrChar = targetCharsTable[indexTarget];

            foreach (char currChar in s)
            {
                 if (seachrChar == currChar)
                 {
                    if (++indexTarget == 10)
                        return "YES";
                    seachrChar = targetCharsTable[indexTarget];
                 }
            }
            
            return "NO";

            ////Solution 2 (Old - Poor)
            //string targetString = "hackerrank";
            //int targetStringInt = 0;
            //foreach (char item in s)
            //{
            //    if (targetStringInt == 10)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        if (targetString[targetStringInt] == item)
            //        {
            //            targetStringInt++;
            //        }
            //    }

            //}
            //if (targetStringInt == 10)
            //{
            //    return "YES";
            //}
            //else
            //{
            //    return "NO";
            //}
        }
    }
}
