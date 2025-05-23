using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1907
    {
        ////(1907.) Count Salary Categories (MEDIUM)
        string SqlQuery =
            @"
                  Select
                      'High Salary' as category,
                      Count(account_id) as accounts_count
                  From 
                  (
                      Select 
                          account_id
                      From Accounts 
                      Where income > 50000
                  ) a 
                  UNION ALL
                  Select
                      'Average Salary' as category,
                      Count(account_id) as accounts_count
                  From 
                  (
                      Select 
                          account_id
                      From Accounts 
                      Where income >= 20000 and income <= 50000
                  ) a 
                  UNION ALL
                  Select
                      'Low Salary' as category,
                      Count(account_id) as accounts_count
                  From 
                  (
                      Select 
                          account_id
                      From Accounts 
                      Where income < 20000
                  ) a 
            ";
    }
}
