using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0160
    {
        ////160. Interviews (HARD)
        //string SqlQuery =
        //@"
        //    WITH totalsubmissions as
        //    (
        //         SELECT 
        //             a.[contest_id]
        //            ,SUM([total_submissions]) as [total_submissions]
        //            ,SUM([total_accepted_submissions]) as [total_accepted_submissions]
        //         FROM [Colleges] as a
        //         LEFT JOIN [Challenges] as b
        //         ON a.[college_id] = b.[college_id] 
        //         LEFT JOIN [Submission_Stats] as c
        //         ON c.challenge_id = b.challenge_id
        //         GROUP BY [contest_id]
        //    ),

        //    totalviews as 
        //    (
        //          SELECT 
        //            a.[contest_id]
        //           ,SUM([total_views]) as [total_views]
        //           ,SUM([total_unique_views]) as [total_unique_views]
        //        FROM [Colleges] as a
        //        LEFT JOIN [Challenges] as b
        //        ON a.[college_id] = b.[college_id] 
        //        LEFT JOIN [View_Stats]  as c
        //        ON c.challenge_id = b.challenge_id
        //        GROUP BY [contest_id]
        //    ),

        //     finale as 
        //     (
        //          SELECT a.[contest_id]
        //                ,[hacker_id]
        //                ,[name]
        //                ,CASE
        //                 When    b.total_submissions is null then  0 else b.total_submissions end as total_submissions
        //                ,CASE
        //                 When    b.total_accepted_submissions is null then  0 else b.total_accepted_submissions end as total_accepted_submissions
        //                ,CASE
        //                 When    c.total_views is null then  0 else c.total_views end as total_views
        //                ,CASE
        //                 When    c.total_unique_views is null then  0 else c.total_unique_views end as total_unique_views

        //          FROM [Contests] as a
        //          Left JOIN totalsubmissions as b
        //          on a.contest_id = b.[contest_id]
        //          Left JOIN totalviews as c
        //          ON a.contest_id = c.contest_id
        //      ),

        //     finalewithout0 as 
        //     (
        //     SELECT 
        //         [contest_id]
        //        ,[hacker_id]
        //        ,[name]
        //        ,total_submissions
        //        ,total_accepted_submissions
        //        ,total_views
        //        ,total_unique_views
        //     FROM finale
        //     )

        //    SELECT * FROM finalewithout0
        //    Where (total_submissions+total_accepted_submissions+total_views+total_unique_views) != 0        
        //";
    }
}
