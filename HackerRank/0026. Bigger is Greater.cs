using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0026
    {
        public string biggerIsGreater(string w)
        {
            int lenghtString = w.Length;
            int index = -1;

            for (int i = lenghtString - 2; i >= 0; i--)
            {
                if (w[i] < w[i + 1])
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                // Console.WriteLine("no answer");
                return "no answer";
            }

            string rightCutString = w.Substring(index + 1);
            for (int i = rightCutString.Length - 1; i >= 0; i--)
            {
                if (rightCutString[i] > w[index])
                {
                    string leftCutString = w.Substring(0, index + 1);
                    char[] left = leftCutString.ToCharArray();
                    char[] right = rightCutString.ToCharArray();

                    char temporaryChar = right[i];
                    right[i] = left[index];
                    left[index] = temporaryChar;
                    Array.Reverse(right);

                    //Console.WriteLine(new String(left) + new string(right).ToString());
                    return new String(left) + new string(right).ToString();
                }
            }
            return "no answer";
        }

    }
}
