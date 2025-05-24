using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1341
    {
        ////(1341.) Movie Rating  (MEDIUM)
        string SqlQuery =
            @"
                    Select
                        f.results
                    From (
                    Select top 1
                        c.name as results             
                    From
                    (
                        Select 
                            user_id,
                            COUNT(user_id) as howManyTimes
                        From MovieRating 
                        Group by user_id 
                    ) as a
                    left join Users as c
                    On c.user_id = a.user_id 
                    Where a.howManyTimes = (Select Max(b.howManyTimes) From (Select 
                            user_id,
                            COUNT(user_id) as howManyTimes
                            From MovieRating 
                            Group by user_id ) b)
                    order by c.name
                    ) f
                    
                    UNION ALL 
                    
                    Select
                        g.results
                    From 
                    ( 
                        Select top 1
                        d.title as results
                    From
                    (
                        Select
                            movie_id,
                            AVG(rating*1.0) as averageRating
                        From MovieRating 
                        Where MONTH(created_at) = 2 and YEAR(created_at) = 2020
                        Group by movie_id
                    ) as a
                    Left join Movies as d
                    On d.movie_id = a.movie_id
                    Where a.averageRating = (Select MAX(b.averageRating) FROM 
                                    (Select
                                        movie_id,
                                        AVG(rating*1.0) as averageRating
                                    From MovieRating 
                                    Where MONTH(created_at) = 2 and YEAR(created_at) = 2020
                                    Group by movie_id) b
                                    ) 
                    order by d.title
                    ) g
                ";

        //OR
        LeetCode_1341 classLeetCode = new LeetCode_1341();
    }
}
