using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3606
    {
        ////(3606.) Coupon Code Validator (EASY)
        public IList<string> ValidateCoupons(string[] code, string[] businessLine, bool[] isActive)
        {
            List<string[]> codeBusinessLineList = new List<string[]>();

            for (int i = 0; i < code.Length; i++)
            {
                if (isActive[i] == true && code[i].Length > 0)
                {
                    if (IsCorrectCode(code[i]))
                    {
                        string temp = businessLine[i];
                        if (temp == "electronics")
                        {
                            codeBusinessLineList.Add(new string[] { code[i], "0" });
                        }
                        else if (temp == "grocery")
                        {
                            codeBusinessLineList.Add(new string[] { code[i], "1" });
                        }
                        else if (temp == "pharmacy")
                        {
                            codeBusinessLineList.Add(new string[] { code[i], "2" });
                        }
                        else if (temp == "restaurant")
                        {
                            codeBusinessLineList.Add(new string[] { code[i], "3" });
                        }
                    }
                }
            }
            codeBusinessLineList = codeBusinessLineList.OrderBy(x => x[1]).ThenBy(x => x[0], StringComparer.Ordinal).ToList();

            return codeBusinessLineList.Select(x => x[0]).ToList();
        }

        private bool IsCorrectCode(string item)
        {
            foreach (char c in item)
            {
                if (c >= 'a' && c <= 'z') continue;
                if (c >= 'A' && c <= 'Z') continue;
                if (c >= '0' && c <= '9') continue;
                if (c == '_') continue;
                return false;
            }
            return true;
        }
    }
}
