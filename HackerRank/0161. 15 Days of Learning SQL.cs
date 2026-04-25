using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0161
    {
        ////161. 15 Days of Learning SQL (HARD)
        //string SqlQuery =
        //@"
        //    WITH RecursiveFUNCTION  AS 
        //    (
        //       SELECT 
        //            [submission_date]
        //            ,[hacker_id]
        //            FROM [Submissions]
        //            WHERE [submission_date] = (SELECT min([submission_date]) FROM [Submissions])

        //            UNION ALL

        //            SELECT    
        //                       a.[submission_date]
        //                      ,a.[hacker_id]
        //            FROM [Submissions] as a
        //            join RecursiveFUNCTION as b 
        //            ON a.[hacker_id] = b.[hacker_id]
        //            WHERE  a.[submission_date] = DATEADD(DAY, 1, b.[submission_date])
        //    )
        //    --SELECT * FROM RecursiveFUNCTION
        //    ,
        //    RecursiveFUNCTIONDISTINCT as 
        //    (
        //       SELECT 
        //             [submission_date]
        //             ,COUNT(DISTINCT [hacker_id]) as howMANY
        //       FROM RecursiveFUNCTION
        //       GROUP BY [submission_date]
        //    )
        //    --SELECT * FROM RecursiveFUNCTIONDISTINCT
        //    ,
        //    pref4 as 
        //    ( 
        //       SELECT [submission_date], hacker_id
        //            ,COUNT(hacker_id) as count_hacker_id
        //       FROM [Submissions] 
        //       GROUP BY submission_date, hacker_id, submission_date
        //    )
        //    --select * from pref4
        //    --order by submission_date
        //    ,
        //    f4 as 
        //    (
        //       SELECT pref4mod.[submission_date]
        //              ,min(pref4join.hacker_id) as hacker_id
        //       FROM (
        //               SELECT [submission_date], max(count_hacker_id) as maxCount 
        //               From pref4 
        //               GROUP BY [submission_date]
        //            ) as pref4mod
        //       join pref4 as pref4join
        //       on pref4mod.[submission_date] = pref4join.[submission_date]
        //       Where count_hacker_id = maxCount
        //       GROUP BY pref4mod.[submission_date]
        //    )
        //    ----select * from f4
        //    ,
        //    AllF4AndRecursive as
        //    (
        //       SELECT 
        //            a.[submission_date]
        //            ,b.howMANY
        //            ,a.[hacker_id]
        //            ,c.[name]
        //       FROM f4 as a
        //       JOIN RecursiveFUNCTIONDISTINCT as b
        //       ON a.[submission_date] = b.submission_date
        //       join [Hackers] as c
        //       ON a.hacker_id = c.hacker_id
        //     )

        //     SELECT * FROM AllF4AndRecursive
        //     order by [submission_date] 
        //";
    }
}
