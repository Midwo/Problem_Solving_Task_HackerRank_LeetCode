using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2273
    {
        ////(2273.) Find Resultant Array After Removing Anagrams (EASY)
        public IList<string> RemoveAnagrams(string[] words)
        {
            string lastString = string.Empty;
            List<string> resultList = new List<string>();
            for (int i = 0; i < words.Length; i++) 
            {
                char[] temp = words[i].ToCharArray();
                Array.Sort(temp);
                string tempString = new string(temp);

                if (lastString != tempString)
                {
                    resultList.Add(words[i]);
                }
                lastString = tempString;
            }

            return resultList;
        }
    }
}
