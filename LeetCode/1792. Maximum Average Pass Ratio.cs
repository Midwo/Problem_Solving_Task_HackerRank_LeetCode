using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1792
    {
        ////(1792.) Maximum Average Pass Ratio (MEDIUM)
        public double MaxAverageRatio(int[][] classes, int extraStudents)
        {
            PriorityQueue<int, double> priorityQueue = new PriorityQueue<int, double>();

            for (int i = 0; i < classes.Length; i++)
            {
                if (classes[i][0] != classes[i][1])
                {
                    double temp = (double)classes[i][0] / (double)classes[i][1];
                    double temp1 = ((double)classes[i][0] + 1) / ((double)classes[i][1]+1);
                    priorityQueue.Enqueue(i, 1-(temp1-temp)); 
                }
            }

            while (extraStudents != 0 && priorityQueue.Count == 0)
            {
                int temp = priorityQueue.Dequeue();
                classes[temp][1]++;
                classes[temp][0]++;


                double temp2 = (double)classes[temp][0] / (double)classes[temp][1];
                double temp3 = ((double)classes[temp][0] + 1) / ((double)classes[temp][1]+1);
                priorityQueue.Enqueue(temp, 1 - (temp3 - temp2));
                

                extraStudents--;
            }


            double result = 0;

            for (int i = 0; i < classes.Length; i++) 
            {
                result += ((double)classes[i][0] / (double)classes[i][1]);
            }

            return (result / classes.Length);
        }
    }
}
