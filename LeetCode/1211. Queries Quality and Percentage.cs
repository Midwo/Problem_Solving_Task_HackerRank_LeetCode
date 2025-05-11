using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1211
    {
        ////(1211.) Queries Quality and Percentage (EASY)
        string SqlQuery =
            @"
                WITH CTE as 
                (
                    Select 
                        query_name,
                         --CONVERT(DECIMAL(16,2), rating/1.0 / position/1.0) as quality,
                         --rating 
                         CONVERT(DECIMAL(16,2),SUM(CONVERT(DECIMAL(16,4), rating/1.0 / position/1.0))/COUNT(*)) as quality,
                         COUNT(*) as count,
                         SUM(IIF(rating<3, 1, 0)) as sum
                     From Queries
                     GROUP BY query_name
                )

                Select 
                    query_name,
                    quality,
                    CONVERT(DECIMAL(16,4),sum*1.0/count*1.0)*100 as poor_query_percentage 
                From CTE
            ";
    }
}
