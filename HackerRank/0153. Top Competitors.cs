using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0153
    {
        ////153. Top Competitors (MEDIUM)
        //string SqlQuery =
        //@"
        //    SELECT 
        //        Hacker_id,
        //        Name_Hacker
        //        --, how_many
        //    FROM
        //        (
        //            SELECT 
        //                a.[hacker_id] as Hacker_id
        //                ,d.[Name] as Name_hacker
        //                --,a.[submission_id]
        //                --,a.[challenge_id]
        //                --,a.[score]
        //                --,b.[difficulty_level]
        //                --,c.[score] as [MAX_SCORE_TEST]
        //                ,COUNT(a.[hacker_id]) as how_many
        //            FROM [Submissions] as a
        //            LEFT JOIN [Challenges] as b
        //            ON a.[challenge_id] = b.[challenge_id]
        //            LEFT JOIN [Difficulty] as c
        //            ON b.[difficulty_level] = c.[difficulty_level]
        //            LEFT JOIN [Hackers] as d
        //            ON a.[hacker_id] = d.[hacker_id]
        //            WHERE a.score = c.score
        //            group by  a.[hacker_id] ,d.[Name]
        //         ) as mm
        //     where how_many > 1
        //     order by how_many desc, [hacker_id]
        //";
    }
}
