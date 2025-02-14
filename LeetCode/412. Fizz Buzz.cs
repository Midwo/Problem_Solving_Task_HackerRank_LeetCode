using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_412
    {
        ////(412.) Fizz Buzz (EASY)
        public IList<string> FizzBuzz(int n)
        {
            IList<string> result = new List<string>();

            for (int i  = 1; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        result.Add("FizzBuzz");
                    }
                    else
                    {
                        result.Add("Fizz");
                    }
                }
                else if (i % 5 == 0)
                {
                    result.Add("Buzz");
                }
                else
                {
                    result.Add(i.ToString());
                }
            }
            return result;
        }
    }
}
