using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2106
    {
        ////(2106.) Maximum Fruits Harvested After at Most K Steps (HARD)
        public int MaxTotalFruits(int[][] fruits, int startPos, int k)
        {
            int maxFruitResult = 0;
            int currSumFruit = 0;
            int length = fruits.Length;

            int x = 0;

            for (int i = 0; i < length; i++)
            {
                int position = fruits[i][0];
                currSumFruit += fruits[i][1];

                //Console.WriteLine(position - fruits[x][0]);
                //Console.WriteLine(Math.Abs(startPos - fruits[x][0]));
                //Console.WriteLine(Math.Abs(startPos - position));

                while (x <= i && position - fruits[x][0] + Math.Min(Math.Abs(startPos - fruits[x][0]), Math.Abs(startPos - position)) > k)
                {
                    currSumFruit -= fruits[x][1];
                    x++;
                }

                maxFruitResult = Math.Max(maxFruitResult, currSumFruit);

            }

            return maxFruitResult;
        }
    }
}
