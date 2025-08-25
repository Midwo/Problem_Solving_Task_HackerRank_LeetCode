using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1741
    {
        ////(1741.) Find Total Time Spent by Each Employee (EASY)

        ////T-SQL query CODE - MS SQL */

        string SqlQuery =
            @"
                    Select  
                        event_day as day,
                        emp_id,
                        SUM(total_time) as total_time
                    From (Select
                        event_day,
                        emp_id,
                        out_time - in_time as total_time
                    From Employees ) a
                    Group by event_day, emp_id
                ";
    }
}
