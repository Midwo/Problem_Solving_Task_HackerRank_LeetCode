using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1491
    {
        ////(1491.) Average Salary Excluding the Minimum and Maximum Salary (EASY)
        public double Average(int[] salary)
        {
            double sumSalary = 0;
            int minSalary = int.MaxValue;
            int maxSalary = int.MinValue;

            foreach(int item in salary)
            {
                sumSalary += item;
                if (minSalary > item)
                {
                    minSalary = item;
                }
                if (maxSalary < item) 
                {
                    maxSalary = item;
                }
            }

            return (sumSalary-minSalary-maxSalary)/ (salary.Length-2);
        }
    }
}
