using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1075
    {
        ////(1075.) Project Employees I (EASY)
        string SqlQuery =
                @"
                    Select 
                        a.project_id,
                        ROUND(CAST(a.Sum_Years AS decimal)/CAST(a.How_Many_Peoples AS decimal),2) as average_years 
                    FROM (
                            Select 
                                a.project_id,
                                SUM(b.experience_years) as Sum_Years, 
                                Count(a.employee_id) as How_Many_Peoples
                            From Project as a
                            left join Employee as b
                            ON a.employee_id  = b.employee_id 
                            GROUP BY a.project_id
                         ) a
                ";
    }
}
