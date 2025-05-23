using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_626
    {
        ////(626.) Exchange Seats (MEDIUM)
        string SqlQuery =
            @"
                  Select
                      id,
                      IIF(id % 2 = 0, 
                  LAG(student, 1, student) OVER (order by id), 
                  LEAD(student, 1, student) OVER (order by id)
                      ) as student 
                  From Seat 
            ";
    }
}
