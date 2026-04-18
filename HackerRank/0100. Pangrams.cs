using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0100
    {
        ////100. Pangrams (EASY)
        public string pangrams(string s)
        {
            ////Solution 1 (New)
            var itExist = new bool[26];

            foreach (var currChar in s) 
            {
                if (currChar != ' ')
                {
                    if (currChar >= 'a')
                        itExist[currChar - 'a'] = true;
                    else
                        itExist[currChar - 'A'] = true;
                }       
            
            }

            foreach (var status in itExist) 
            {
                if (!status)
                    return "not pangram";
            }

            return "pangram";


            ////Solution 2 (Old)

            //string alphabet = "abcdefghijklmnopqrstuvwxyz";
            //var x = s.ToLower().Distinct();
            //string combinedString = string.Join("", x);
            //combinedString = combinedString.Replace(" ", "");
            //int x0 = combinedString.Length;
            //if (combinedString.Length != 26)
            //{
            //    return "not pangram";
            //}
            //foreach (var item in combinedString)
            //{
            //    bool isHere = false;
            //    foreach (var item1 in alphabet)
            //    {
            //        if (item == item1)
            //        {
            //            isHere = true;
            //        }
            //    }
            //    if (isHere == false)
            //    {
            //        return "not pangram";
            //    }
            //}

            //return "pangram";
        }
    }
}
