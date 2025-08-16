using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1323
    {
        ////(1323.) Maximum 69 Number (EASY)
        public int Maximum69Number(int num)
        {
            string result = num.ToString();

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == '6')
                {
                    result = result.Substring(0, i) + '9' + result.Substring(i+1, result.Length - i-1);
                    //string tempPrev = stringNum.Substring(0, i);
                    //string tempAfter = stringNum.Substring(i+1, stringNum.Length - i-1);
                    break;
                }
            }

            return int.Parse(result);
        }
    }
}
