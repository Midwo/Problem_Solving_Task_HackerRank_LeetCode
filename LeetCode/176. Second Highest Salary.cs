using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_176
    {
        ////(176.) Second Highest Salary (MEDIUM)
        string SqlQuery =
                @"
                    Select 
                        a.employee_id
                    --    a.name, 
                    --    a.manager_id, 
                    --    a.salary,
                    --    b.employee_id 
                    From Employees as a 
                    Left join Employees b
                    ON a.manager_id = b.employee_id 
                    Where a.salary < 30000 and  b.employee_id is null and a.manager_id is not null
                    order by a.employee_id
                ";
    }
}
