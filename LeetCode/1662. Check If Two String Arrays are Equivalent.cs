using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1662
    {
        ////(1662.) Check If Two String Arrays are Equivalent (EASY)
        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            string word1String = string.Join("",word1);
            string word2String = string.Join("", word2);

            if(word1String != word2String)
            {
                return false;
            }
            return true;
        }
    }
}
