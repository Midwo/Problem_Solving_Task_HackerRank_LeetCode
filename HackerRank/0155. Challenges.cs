using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0155
    {
        ////155. Challenges (MEDIUM)
        //string SqlQuery =
        //@"
        //        DECLARE @maxCreateChallenes int
        //        SET @maxCreateChallenes = 
        //            (
        //                SELECT max(x) as x FROM
        //                (
        //                    SELECT
        //                        COUNT(*) as x
        //                    FROM [Hackers] as A
        //                    LEFT JOIN [Challenges] as B
        //                    ON a.[hacker_id] = b.[hacker_id]
        //                    GROUP BY a.[hacker_id] 
        //                ) as max
        //            );
                
        //        WITH CTE1 (hacker_id1, name1, CREATED_Challenges)
        //        as (
        //          SELECT 
        //                DISTINCT a.[hacker_id],
        //                a.[name],
        //                Count(*) as CREATED_Challenges
                    
        //          FROM [Hackers] as A
        //          LEFT JOIN [Challenges] as B
        //          ON a.[hacker_id] = b.[hacker_id]
        //          GROUP BY a.[hacker_id],
        //                a.[name]
        //            )
                
        //        SELECT a.hacker_id1, a.name1, a.CREATED_Challenges
        //        FROM CTE1 as a
        //        left JOIN (SELECT
        //            CREATED_Challenges,
        //            COUNT(CREATED_Challenges) as how_many_people
        //            FROM CTE1 as a
        //            GROUP BY CREATED_Challenges
        //            Having CREATED_Challenges = @maxCreateChallenes or COUNT(CREATED_Challenges) = 1) as b
        //        ON a.CREATED_Challenges = b.CREATED_Challenges
        //        Where how_many_people is not null
        //        order by CREATED_Challenges desc, hacker_id1 
        //    ";
    }
}
