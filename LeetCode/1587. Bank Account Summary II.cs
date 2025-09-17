using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1587
    {
        ////(1587.) Bank Account Summary II (EASY)
  
        // 374ms, Beats: 80.73%
        string SqlQuery =
                @"
                    Select 
                        a.name
                        ,SUM(b.amount) balance 
                    From Users a 
                    left join Transactions b
                    ON a.account = b.account
                    Group by a.name
                    having SUM(b.amount) > 10000     
                ";
    }
}
