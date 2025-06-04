using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_120
    {
        //////(120.) Triangle (MEDIUM)
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            int height = triangle.Count;
            int[] sum = new int[height+1];

            for (int i = height - 1; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                   sum[j] = Math.Min(sum[j], sum[j+1]) + triangle[i][j];
                   //Console.WriteLine(triangle[i][j]);
                }
            }

            return sum[0];
        }

        ////Recursive method - too slow
        
        //private int _minSumTriagle;
        //private IList<IList<int>> _triangle;
        //private int _maxLevel;
        //public int MinimumTotal(IList<IList<int>> triangle)
        //{
        //    _minSumTriagle = int.MaxValue;
        //    _triangle = triangle;
        //    _maxLevel = triangle.Count-1;

        //    if (_maxLevel == 0)
        //    {
        //        return triangle[0][0];
        //    }

        //    MinSumTriagleDP(_triangle[0][0], 0, 0);

        //    return _minSumTriagle;
        //}

        //private void MinSumTriagleDP(int sum, int level, int index)  
        //{
        //    if (level == _maxLevel)
        //    {
        //        _minSumTriagle = Math.Min(_minSumTriagle, sum);
        //        return;
        //    }
        //    level++;

        //    //if (index-1 >= 0)
        //    //{
        //    //    MinSumTriagleDP(_triangle[level][index - 1] + sum, level, index - 1);
        //    //}

        //    MinSumTriagleDP(_triangle[level][index] + sum, level, index);

        //    if (index+1 <= level+1)
        //    {
        //        MinSumTriagleDP(_triangle[level][index + 1] + sum, level, index + 1);
        //    }
        //}
    }
}
