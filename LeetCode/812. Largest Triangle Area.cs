using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_812
    {
        ////(812.) Largest Triangle Area (EASY)
        public double LargestTriangleArea(int[][] points)
        {
            // Area = 0.5∗(∣)x1​⋅(y2​−y3​)+x2​⋅(y3​−y1​)+x3​⋅(y1​−y2​))   
            double maxArea = 0;
            int length = points.Length;
            for (int i = 0; i < length-2; i++)
            {
                int[] a = points[i];
                for (int j = i+1; j < length-1; j++)
                {
                    int[] b = points[j];
                    for (int k = j+1; k < length; k++)
                    {
                        int[] c = points[k];
                        double currMaxArea = Math.Abs(((0.5) * (a[1]*(b[0] - c[0]) + b[1] * (c[0] - a[0]) + c[1] * (a[0] - b[0]))));
                        maxArea = maxArea < currMaxArea ? currMaxArea : maxArea;
                    }
                }
            } 

            return maxArea;
        }
    }
}
