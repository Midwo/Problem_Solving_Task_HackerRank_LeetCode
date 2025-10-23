using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1890
    {
        ////(1890.) The Latest Login in 2020 (EASY)
        string SqlQuery =
            @"
                Select
                    user_id
                    ,MAX(time_stamp) as last_stamp
                From Logins 
                WHERE YEAR(time_stamp) = '2020'
                GROUP BY user_id
            ";
    }
}
