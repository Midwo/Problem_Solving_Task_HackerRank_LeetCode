using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1789
    {
        ////(1789.) Primary Department for Each Employee (EASY)
        string SqlQuery =
            @"
                    With CTE AS 
                    (
                        Select 
                            employee_id,
                            Count(*) as howManyDepartment
                        From Employee 
                        Group by employee_id
                    )
                    
                    Select
                        a.employee_id,
                        a.department_id  
                    From 
                    (
                        Select
                            a.employee_id,
                            b.department_id  
                        From CTE a
                        Left join Employee b
                        On a.employee_id = b.employee_id
                        Where howManyDepartment > 1 and b.primary_flag = 'Y'
                    ) a
                    Union
                    Select
                        b.employee_id,
                        b.department_id
                    From
                    (
                        Select
                            a.employee_id,
                            b.department_id 
                        From CTE a
                        Left join Employee b
                        On a.employee_id = b.employee_id
                        Where howManyDepartment = 1
                    ) b
                ";
    }
}
