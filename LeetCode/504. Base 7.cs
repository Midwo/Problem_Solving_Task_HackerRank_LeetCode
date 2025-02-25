using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_504
    {
        ////(504.) Base 7 (EASY)
        public string ConvertToBase7(int num)
        {
            if (num == 0)
            {
                return "0";
            }
            List<char> resultList = new List<char>();
            bool minusValue = num < 0;
            num = Math.Abs(num);
            while (num > 0)
            {
                resultList.Insert(0, (char)(num % 7 + '0'));
                num /= 7;
            }

            if (minusValue)
            {
                resultList.Insert(0, '-');
            }

            return new string(resultList.ToArray());
        }
    }
}
