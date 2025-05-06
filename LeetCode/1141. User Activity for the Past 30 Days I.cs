using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1141
    {
        ////(1141.) User Activity for the Past 30 Days I (EASY)
        string SqlQuery =
                 @"
                    Select
                        activity_date as day,
                        COUNT(distinct user_id)  as active_users 
                    FROM Activity 
                    Where activity_date > DATEADD(Day, -30, '2019-07-27') and activity_date <= '2019-07-27'
                    GROUP BY activity_date
                ";
    }
}
