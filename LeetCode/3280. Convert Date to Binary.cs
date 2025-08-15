using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3280
    {
        ////(3280.) Convert Date to Binary (EASY)
        public string ConvertDateToBinary(string date)
        {
            string[] arrayDate = date.Split('-');
            StringBuilder sb = new StringBuilder();

            sb.Append(Convert.ToString(int.Parse(arrayDate[0]), 2));
            sb.Append('-');
            sb.Append(Convert.ToString(int.Parse(arrayDate[1]), 2));
            sb.Append('-');
            sb.Append(Convert.ToString(int.Parse(arrayDate[2]), 2));

            return sb.ToString();
        }
    }
}
