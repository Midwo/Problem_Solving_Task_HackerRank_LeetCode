using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3174
    {
        ////(3174.) Clear Digits (EASY)
        public string ClearDigits(string s)
        {
            StringBuilder sb = new StringBuilder(s);
            bool end = false;
            int index = 0;
                        
            if (s.Length < 2)
            {
                return s;
            }

            while (!end)
            {
                if (sb[index+1] <  'a' && sb[index] >= 'a')
                {
                    sb.Remove(index, 2);
                    index--;
                }
                else
                {
                    index++;
                }

                if (index +1 >= sb.Length)
                {
                    end = true;
                }
            }

            return new string(sb.ToString());
        }
    }
}
