using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1934
    {
        ////(1934.) Confirmation Rate (MEDIUM)
        string SqlQuery =
            @"
                    With CTE AS
                    (
                        Select
                            user_id,
                            (SUM(IIF([action] = 'timeout', 1, 0))) as countTimeout,
                            (SUM(IIF([action] = 'confirmed', 1, 0))) as countConfirmed
                        From Confirmations 
                        GROUP BY user_id
                    )
                    
                    Select 
                        a.user_id,
                        IIF(b.confirmation_rate is null, 0, b.confirmation_rate) as confirmation_rate
                    From Signups as a
                    Left Join (Select 
                                user_id,
                                ROUND(countConfirmed*1.0 / (countTimeout*1.0 + countConfirmed*1.0),2) as confirmation_rate 
                              From CTE ) as b
                    ON a.user_id = b.user_id
                ";

    }
}
