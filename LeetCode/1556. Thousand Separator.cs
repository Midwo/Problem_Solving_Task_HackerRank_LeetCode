using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1556
    {
        ////(1556.) Thousand Separator (EASY)
        public string ThousandSeparator(int n)
        {
            if(n < 1000)
            {
                return n.ToString();
            }

            string stringN = n.ToString();
            StringBuilder sb = new StringBuilder();
            int counter = 0;
            for (int i = stringN.Length-1; i >= 0 ; i--) 
            {
                if (counter == 3)
                {
                    counter = 0;
                    sb.Append('.');
                }
                counter++;
                sb.Append(stringN[i]);
            }

            char[] arrayN = sb.ToString().ToCharArray();
            Array.Reverse(arrayN);
            return new string (arrayN);
        }
    }
}
