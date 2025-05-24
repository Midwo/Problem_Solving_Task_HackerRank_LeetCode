using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_602
    {
        ////(602.) Friend Requests II: Who Has the Most Friends (MEDIUM)
        string SqlQuery =
                @"
                      With CTE AS
                      (
                          Select
                              a.id,
                              IIF(b.howMany is null, 0, b.howMany)+IIF(c.howMany is null, 0, c.howMany) as num
                          From
                          (
                              Select
                                  distinct requester_id as id
                              From RequestAccepted 
                              UNION 
                              Select
                                  distinct accepter_id  as id
                              From RequestAccepted
                          ) a
                          left join 
                          (
                              Select
                                  accepter_id,
                                  count(*) as howMany
                              From RequestAccepted 
                              Group by accepter_id
                          ) b
                          ON a.id = b.accepter_id
                          left join 
                          (
                              Select
                                  requester_id,
                                  count(*) as howMany
                              From RequestAccepted 
                              Group by requester_id
                          ) c 
                          ON a.id = c.requester_id
                      )
                      
                      Select top 1
                          id,
                          num
                      From CTE
                      Order by num desc
                ";
    }
}
