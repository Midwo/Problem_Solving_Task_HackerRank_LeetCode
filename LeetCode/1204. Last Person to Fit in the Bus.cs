using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1204
    {
        ////(1204.) Last Person to Fit in the Bus (MEDIUM)
        string SqlQuery =
                @"
                     Select top 1
                         a.person_name
                     FROM
                     ( 
                         Select
                             person_id, 
                             person_name,
                             weight,
                             turn,
                             SUM(weight)
                             OVER (order by turn) as SumWeight
                         FROM Queue
                     ) a
                     Where SumWeight <= 1000
                     order by a.turn desc
                ";
    }
}
