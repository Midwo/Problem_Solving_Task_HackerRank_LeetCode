using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0156
    {
        ////156. Contest Leaderboard (MEDIUM)
        //string SqlQuery =
        //@"
        //    SELECT 
        //        SUM_PRE.[hacker_id], 
        //        b.[name], 
        //        SUM(max_score) as TOTAL_SCORE
        //    FROM 
        //    (
        //        SELECT 
        //            [hacker_id], 
        //            [challenge_id], 
        //            max_score
        //        FROM 
        //        (
        //            SELECT 
        //                [hacker_id]
        //                ,[challenge_id]
        //                ,max([score]) as max_score
        //            FROM [Submissions]
        //            GROUP BY  [hacker_id] ,[challenge_id] ,[challenge_id]
        //        ) as MAX_SCORE
        //    ) as SUM_PRE
        //    LEFT JOIN  [Hackers] as b
        //    ON SUM_PRE.[hacker_id] = b.hacker_id
        //    Group by SUM_PRE.[hacker_id], b.[name]
        //    HAVING SUM(max_score) > 0
        //    order by TOTAL_SCORE desc, SUM_PRE.[hacker_id]
        //";

    }
}
