using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_180
    {
        ////(180.) Consecutive Numbers (MEDIUM)
        string SqlQuery =
            @"
                    Select
                        distinct a.num as ConsecutiveNums 
                    From
                    (
                        Select
                            id,
                            num,
                            LAG(num)
                            OVER (ORDER BY [id]) AS PrevNum,
                            LEAD(num) 
                            OVER (ORDER BY [id]) AS NextNum
                        From Logs 
                    ) a
                    where a.num = a.PrevNum and a.num = a.NextNum
            ";
    }
}
