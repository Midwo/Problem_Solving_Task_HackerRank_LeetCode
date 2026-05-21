using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3043
    {
        ////(3043.) Find the Length of the Longest Common Prefix (MEDIUM)
        public int LongestCommonPrefix(int[] arr1, int[] arr2)
        {
            int maxValuePrefix = -1;
            var hashSetListPrefix = new HashSet<string>();

            foreach (int currArr2 in arr2) 
            {
                string currString = string.Empty;
                
                foreach (var item in currArr2.ToString())
                {
                    currString += item;
                    hashSetListPrefix.Add(currString);
                }
            }

            foreach (int currArr1 in arr1) 
            { 
                string currArrToString = currArr1.ToString();

                if (currArrToString.Length > maxValuePrefix)
                {
                    int currStartIndex = maxValuePrefix == -1 ? 0 : maxValuePrefix;
                    for (int i = currStartIndex; i < currArrToString.Length; i++)
                    {
                        if (hashSetListPrefix.Contains(currArrToString[0..(i+1)]))
                        {
                            maxValuePrefix = i+1;
                        }
                    }
                }
            }

            return maxValuePrefix != -1? maxValuePrefix : 0;
        }
    }
}
