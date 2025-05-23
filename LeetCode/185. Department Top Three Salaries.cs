using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_185
    {
        ////(185.) Department Top Three Salaries (HARD)
        string SqlQuery =
            @"
                     Select 
                         b.Name as Department,
                         a.Name as Employee,
                         a.Salary
                     From 
                     (
                         Select
                             id,
                             name,
                             salary,
                             departmentId,
                             Dense_Rank() OVER (PARTITION BY departmentId ORDER BY [salary] desc) as Rank
                         From Employee
                     ) a
                     left join Department as b
                     On a.departmentId = b.id
                     Where a.Rank < 4
            ";
    }
}
