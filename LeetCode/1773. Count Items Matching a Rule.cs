using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1773
    {
        ////(1773.) Count Items Matching a Rule (EASY)
        public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            int count = 0;

            for (int i = 0; i < items.Count; i++)
            {
                if(ruleKey == "type")
                {
                    if (items[i][0] == ruleValue) {  count++; }
                }
                else if (ruleKey == "color")
                {
                    if (items[i][1] == ruleValue) {  count++; }
                }
                else
                {
                    if (items[i][2] == ruleValue) { count++; }
                }
            }

            return count;
        }
    }
}
