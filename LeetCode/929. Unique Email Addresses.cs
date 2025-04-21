using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_929
    {
        ////(929.) Unique Email Addresses (EASY)
        public int NumUniqueEmails(string[] emails)
        {
            HashSet<string> result = new HashSet<string>();
            
            for (int i = 0; i < emails.Length; i++)
            {
                string stringBeforeMonkey = string.Empty;

                string[] stringSplitEmailAfterBeforeMonkey = emails[i].Split('@');
                int firstPLusIndex = stringSplitEmailAfterBeforeMonkey[0].IndexOf('+');
                if (firstPLusIndex > 0)
                {
                    stringBeforeMonkey = stringSplitEmailAfterBeforeMonkey[0][..firstPLusIndex].Replace(".", "");
                }
                else
                {
                    stringBeforeMonkey = stringSplitEmailAfterBeforeMonkey[0].Replace(".", "");
                }
                result.Add(stringBeforeMonkey + '@'+stringSplitEmailAfterBeforeMonkey[1]);
            }
        
            return result.Count;
        }
    }
}
