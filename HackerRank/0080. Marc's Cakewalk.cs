using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0080
    {
        ////80. Marc's Cakewalk (EASY)
        public long marcsCakewalk(List<int> calorie)
        {
            calorie.Sort();
            long multiplier = 1;
            long sumValue = 0;

            for (int i = calorie.Count - 1; 0 <= i; i--)
            {
                sumValue += calorie[i] * multiplier;
                multiplier *= 2;
                //OR better:
                //multiplier <<= 1;
            }

            return sumValue;


            ////Old version
            //calorie.Sort();

            //double SumValue = 0;
            //for (int i = calorie.Count - 1; 0 <= i; i--)
            //{
            //    SumValue = SumValue + (calorie[calorie.Count - i - 1] * Math.Pow(2, i));
            //    // Console.WriteLine(SumValue);
            //}
            //return (long)SumValue;
        }

    }
}
