using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_482
    {
        ////(482.) License Key Formatting (EASY)
        public string LicenseKeyFormatting(string s, int k)
        {
            List<string> list = new List<string>();
            string currString = string.Empty;
            int counter = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != '-')
                {
                    counter++;
                    currString = s[i] + currString;
                    if (counter == k)
                    {
                        list.Add(currString.ToUpper());
                        currString = string.Empty;
                        counter = 0;
                    }
                }
            }
            if (counter != 0)
            {
                list.Add(currString.ToUpper());
            }
            list.Reverse();
            return string.Join("-", list);
        }
    }
}
