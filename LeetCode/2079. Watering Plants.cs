using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2079
    {
        ////(2079.) Watering Plants (MEDIUM)
        public int WateringPlants(int[] plants, int capacity)
        {
            int sum = 1;
            int restWater = capacity - plants[0];

            for (int i = 1; i < plants.Length; i++)
            {
                if(restWater >= plants[i])
                {
                    sum++;
                    restWater -= plants[i];
                }
                else
                {
                    restWater = capacity - plants[i];
                    sum += (i * 2) + 1;
                }
            }

            return sum;
        }
    }
}
