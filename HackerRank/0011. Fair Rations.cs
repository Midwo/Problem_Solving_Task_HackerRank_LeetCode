using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0011
    {
        public string fairRations(List<int> B)
        {
            int howManyRations = 0;
            bool failRations = false;
            for (int i = 0; i < B.Count; i++)
            {
                // Console.WriteLine(B[i]);
                if ((B[B.Count - 1] % 2 != 0) && (i == B.Count - 1))
                {
                    failRations = true;
                    break;
                }
                else if (B[i] % 2 != 0)
                {
                    B[i]++;
                    B[i + 1]++;
                    howManyRations += 2;
                }
            }
            return failRations == true ? "NO" : howManyRations.ToString();
        }

    }
}
