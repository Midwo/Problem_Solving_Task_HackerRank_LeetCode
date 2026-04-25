using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0159
    {
        ////159. Symmetric Pairs (MEDIUM)
        //string SqlQuery =
        //@"
        //    WITH GROUP_BY (xy)
        //    AS (
        //        SELECT 
        //            case
        //                when X<=Y then CONCAT(X,Y)
        //                when X>=Y then CONCAT(Y,X)
        //            end as xy
        //        FROM [Functions]
        //        GROUP BY case
        //                  when X<=Y then CONCAT(X,Y)
        //                  when X>=Y then CONCAT(Y,X)
        //                  end
        //        HAVING COUNT(case
        //                  when X<=Y then CONCAT(X,Y)
        //                  when X>=Y then CONCAT(Y,X)
        //             end)  > 1
        //        )

        //    SELECT 
        //    xy1.x, xy1.y 
        //    --main.xy
        //    FROM GROUP_BY as main
        //    LEFT JOIN  (
        //                    SELECT x,
        //                           y,
        //                           CASE
        //                                       when X<=Y then CONCAT(X,Y)
        //                                    when X>=Y then CONCAT(Y,X)
        //                           end as xy
        //                    FROM [Functions]
        //                ) as xy1
        //    ON main.xy = xy1.xy
        //    GROUP BY xy1.x, xy1.y
        //    Having xy1.x <= xy1.y
        //    order by x
        //";
    }
}
