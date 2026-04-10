using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0050
    {
        ////50. Angry Professor (EASY)
        public string angryProfessor(int k, List<int> a)
        {
            int notToolate = 0;
            foreach (int item in a)
            {
                if (item <= 0)
                {
                    notToolate++;
                }
            }
            if (notToolate >= k)
            {
                return "NO";
            }
            else
            {
                return "YES";
            }
        }
    }
}
