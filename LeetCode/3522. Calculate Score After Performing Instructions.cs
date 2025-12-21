using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3522
    {
        ////(3522.) Calculate Score After Performing Instructions (MEDIUM)
        public long CalculateScore(string[] instructions, int[] values)
        {
            long score = 0;
            int index = 0;
            int lenght = values.Length;
            bool[] visited = new bool[lenght];

            while(index >= 0 && index < lenght && !visited[index])
            {
                visited[index] = true;
                if (instructions[index][0] == 'j')
                {
                    index += values[index];
                }
                else
                {
                    score += values[index++];
                }
            }

            return score;
        }
    }
}
