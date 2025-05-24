using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1321
    {
        ////(1321.) Restaurant Growth (MEDIUM)
        string SqlQuery =
                @"
                     Select 
                         b.visited_on,
                         --b.startCalc,
                         --b.YES_NO,
                         (Select SUM(amount) From Customer Where visited_on >= b.startCalc and visited_on <= b.visited_on) as amount, 
                         (Select ROUND(AVG(f.amount*1.0),2) From (Select 
                     	                                            visited_on,
                     	                                            SUM(amount) as amount
                                                                 From Customer 
                                                                 Group by visited_on) f Where f.visited_on >= b.startCalc and f.visited_on <= b.visited_on) as average_amount
                     From
                     (
                     Select
                         distinct a.end_date as visited_on,
                         a.startCalc,
                         a.YES_NO
                     From
                     (
                         Select
                             visited_on as startCalc,
                             IIF(DATEADD(DAY, 6, visited_on) <= (Select max(visited_on) From Customer), 1, 0) as YES_NO,
                             DATEADD(DAY, 6, visited_on) as end_date
                         From Customer
                     ) a
                     Where a.YES_NO = 1
                     ) b  
                ";
    }
}
