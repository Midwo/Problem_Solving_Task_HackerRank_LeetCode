using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3000
    {
        ////(3000.) Maximum Area of Longest Diagonal Rectangle (EASY)
        public int AreaOfMaxDiagonal(int[][] dimensions)
        {
            int maximumArea = 0;
            double maxValueWithoutSqrt = 0;

            for (int i = 0; i < dimensions.Length; i++)
            {
                double forIndex0 = dimensions[i][1] * dimensions[i][1] + dimensions[i][0] * dimensions[i][0];

                if (maxValueWithoutSqrt <= forIndex0)
                {
                    int tempArea = dimensions[i][1] * dimensions[i][0];
                    
                    if (maxValueWithoutSqrt < forIndex0)
                    {
                        maxValueWithoutSqrt = forIndex0;
                        maximumArea = tempArea;
                    }
                    else
                    {
                        if (tempArea > maximumArea)
                        {
                            maximumArea = tempArea;
                        }
                    }
                }
            }
            
            return maximumArea;
        }
    }
}
