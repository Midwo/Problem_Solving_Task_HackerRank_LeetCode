using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0055
    {
        ////55. Sequence Equation (EASY)
        public List<int> permutationEquation(List<int> p)
        {
            List<int> newList = new List<int>();
            int length = p.Count;

            for (int i = 1; i <= length; i++)
            {
                bool statusBreak = false;
                for (int j = 0; j < length; j++)
                {
                    if (p[j] == i)
                    {
                        for(int k = 0; k < length; k++)
                        {
                            if (p[k] == j + 1)
                            {
                                newList.Add(k+1);
                                statusBreak = true;
                                break;
                            }
                        }
                        if (statusBreak)
                        {
                            break;
                        }                                
                    }
                }
            }
            return newList;
        }
    }
}
