using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0108
    {
        ////108. Two Characters (EASY)
        public int alternate(string s)
        {
            ////Solution 1 (New - Better)
            var itExist = new bool[26];

            foreach (var item in s)
            {
                itExist[item - 'a'] = true;
            }

            int maxLengthWithTwoChar = 0;

            for (var i = 0; i < 25; i++)
            {
                if (itExist[i])
                {
                    char firstChar = (char)('a' + i);
                    for (var j = i+1; j < 26; j++)
                    {
                        if (itExist[j])
                        {
                            char secondChar = (char)('a' + j);
                            int lengthString = 0;
                            char lastCharAdd = ' ';
                            bool status = true;
                            for (var k = 0; k < s.Length; k++)
                            {
                                char currChar = s[k];
                                if(currChar == firstChar  || currChar == secondChar)
                                {
                                    if(lastCharAdd != currChar)
                                    {
                                        lastCharAdd = currChar;
                                        lengthString++;
                                    }
                                    else
                                    {
                                        status = false;
                                        break;
                                    }
                                }
                            }
                            if (status)
                            {
                                maxLengthWithTwoChar = maxLengthWithTwoChar < lengthString ? lengthString : maxLengthWithTwoChar;  
                            }
                        }
                    }
                }
            }

            return maxLengthWithTwoChar;


            ////Solution 2 (Old - Poor)
            //int lenghtString = s.Length;
            //List<string> allCharsFromString = new List<string>();
            //List<string> listStringFromChar = new List<string>();
            //int howLongMax = 0;
            //foreach (char item in s)
            //{
            //    if (!allCharsFromString.Contains(item.ToString()))
            //    {
            //        allCharsFromString.Add(item.ToString());
            //    }
            //}
            //allCharsFromString.Sort();
            //for (int i = 0; i < allCharsFromString.Count; i++)
            //{
            //    for (int j = i + 1; j < allCharsFromString.Count; j++)
            //    {
            //        listStringFromChar.Add(allCharsFromString[i].ToString() + allCharsFromString[j].ToString());
            //    }
            //}
            //foreach (var item in listStringFromChar)
            //{
            //    string x = string.Empty;
            //    foreach (var charS in s)
            //    {
            //        if (charS == item[0] || charS == item[1])
            //        {
            //            x += charS;
            //        }
            //    }
            //    char lastChar = x[0];
            //    for (int k = 1; k < x.Length; k++)
            //    {
            //        if (lastChar == x[k])
            //        {
            //            x = "";
            //            break;
            //        }
            //        else
            //        {
            //            lastChar = x[k];
            //        }
            //    }
            //    if (x.Length > 0 && x.Length > howLongMax)
            //    {
            //        howLongMax = x.Length;
            //    }
            //}
            //return howLongMax;
        }
    }
}
