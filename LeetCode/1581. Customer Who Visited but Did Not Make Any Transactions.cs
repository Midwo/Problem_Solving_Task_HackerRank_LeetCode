using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1581
    {
        ////(1581.) Customer Who Visited but Did Not Make Any Transactions (EASY)
        string SqlQuery =
                @"
                    Select
                        unique_id,
                        b.name
                    From EmployeeUNI as a
                    right Join Employees as b
                    ON a.id = b.id      
                ";
    }
}
