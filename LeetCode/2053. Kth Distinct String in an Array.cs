using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2053
    {
        ////(2053.) Kth Distinct String in an Array (EASY)
        public string KthDistinct(string[] arr, int k)
        {
            ////Method 2x HashSet
            HashSet<string> oneOrMoreCount = new HashSet<string>();
            HashSet<string> twoOrMoreCount = new HashSet<string>();

            foreach (string currStringArr in arr)
            {
                if (!oneOrMoreCount.Add(currStringArr))
                {
                    twoOrMoreCount.Add(currStringArr);
                }
            }

            int indexDistinctString = 0;

            foreach (string currString in arr)
            {
                if (!twoOrMoreCount.Contains(currString))
                {
                    indexDistinctString++;
                    if (indexDistinctString == k)
                    {
                        return currString;
                    }
                }
            }

            return string.Empty;

            ////Method Disctionary
            //Dictionary<string, int> dictionaryCountString = new Dictionary<string, int>();

            //foreach (string currStringArr in arr)
            //{
            //    if (dictionaryCountString.ContainsKey(currStringArr))
            //    {
            //        dictionaryCountString[currStringArr]++;
            //    }
            //    else
            //    {
            //        dictionaryCountString.Add(currStringArr, 1);
            //    }
            //}

            //int indexDistinctString = 0;

            //foreach (string currString in arr)
            //{
            //    if (dictionaryCountString[currString] == 1)
            //    {
            //        indexDistinctString++;
            //        if (indexDistinctString == k)
            //        {
            //            return currString;
            //        }
            //    }
            //}

            //return string.Empty;
        }
    }
}
