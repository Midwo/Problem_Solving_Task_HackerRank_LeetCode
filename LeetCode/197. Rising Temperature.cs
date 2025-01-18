using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_197
    {
        ////(197.) Rising Temperature (EASY)
        string SqlQuery = @"
        WITH CTE
                AS
                (
                    SELECT[id]
                    , [temperature]
                    , recordDate

                    , lag(temperature) OVER (ORDER BY [recordDate]) as b
                    ,DATEDIFF(day, lag(recordDate) OVER (ORDER BY [recordDate]), [recordDate]) as c
                    FROM Weather
                )
                SELECT id
                FROM CTE Where temperature > b
                and c = 1
                order by[recordDate];";
    }
}
