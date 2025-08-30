using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2545
    {
        ////(2545.) Sort the Students by Their Kth Score (MEDIUM)
        public int[][] SortTheStudents(int[][] score, int k)
        {
            int[] scores = new int[score.Length];

            for (int i = 0; i < score.Length; i++)
            {
                scores[i] = score[i][k];
            }

            scores = scores.OrderByDescending(c => c).ToArray();

            int indexSwap = 0;
            for (int i = 0; i < scores.Length; i++) 
            {
                for (int j = indexSwap; j < score.Length; j++)
                {
                    if (score[j][k] == scores[indexSwap])
                    {
                        int[] tempRow = score[indexSwap];
                        score[indexSwap] = score[j];
                        score[j] = tempRow;
                        break;
                    }
                }
            
                indexSwap++;
            }

            return score;
        }
    }
}
