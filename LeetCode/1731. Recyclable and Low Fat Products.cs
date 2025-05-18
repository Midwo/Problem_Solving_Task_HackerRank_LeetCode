using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1731
    {
        ////(1731.) Recyclable and Low Fat Products (EASY)
        string SqlQuery =
                @"
                    Select 
                        a.reports_to as employee_id, 
                        b.name,
                        a.reports_count,
                        ROUND(a.sumAge*1.0/reports_count,0) as average_age 
                    FROM
                    (
                        Select 
                            reports_to,
                            SUM(age) as sumAge,
                            Count(*) as reports_count
                        From Employees 
                        Where reports_to is not null
                        Group by reports_to
                    ) as a 
                    left join Employees as b 
                    ON a.reports_to = b.employee_id 
                ";
    }
}
