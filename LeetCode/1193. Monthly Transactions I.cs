using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1193
    {
        ////(1193.) Monthly Transactions I (MEDIUM)
        string SqlQuery =
                @"
                    Select
                        a.month,
                        a.country,
                        Count(*) as trans_count,
                        SUM(a.approved_count) as approved_count,
                        SUM(a.trans_total_amount) as trans_total_amount,
                        SUM(a.approved_total_amount) as approved_total_amount
                    From (Select
                            FORMAT(trans_date, 'yyyy-MM') as month,
                            country,
                            IIF(state = 'approved', 1, 0) as approved_count,
                            amount as  trans_total_amount,
                            IIF(state = 'approved', amount, 0) as approved_total_amount 
                          From Transactions 
                         ) as a
                    Group by a.month, a.country
                    order by a.month   
                ";

    }
}
