using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1768
    {
        ////(1768.) Merge Strings Alternately (EASY)
        public string MergeAlternately(string word1, string word2)
        {
            ////58ms, Beats: 88.90%

            int length1 = word1.Length;
            int length2 = word2.Length;
            int sumLength = length1 + length2;
            int curr = 0;
            
            StringBuilder resultStringBuilder = new StringBuilder();
            
            int index1 = 0;
            int index2 = 0;

            while (curr < sumLength) 
            {
                if(index1 < length1)
                {
                    resultStringBuilder.Append(word1[index1]);
                    index1++;
                    curr++;
                }   
                if(index2 < length2)
                {
                    resultStringBuilder.Append(word2[index2]);
                    index2++;
                    curr++;
                }
            }

            return new string(resultStringBuilder.ToString());
        }
    }
}
