using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3285
    {
        ////(3285.) Find Indices of Stable Mountains (EASY)
        public IList<int> StableMountains(int[] height, int threshold)
        {
            List<int> listResult = new List<int>();
            int lastValue = height[0];

            for (int i = 1; i < height.Length; i++) 
            {
                if(lastValue > threshold)
                {
                    listResult.Add(i);
                }
                lastValue = height[i];
            }

            return listResult.ToArray();
        }
    }
}
