using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_570
    {
        ////(570.) Managers with at Least 5 Direct Reports (Medium)
        string SqlQuery =
                @"
                    With CTE AS 
                    (
                        Select
                            managerId
                        From Employee
                        GROUP BY managerId
                        HAVING Count(*) >= 5
                    )
                    
                    Select 
                        a.name
                    From Employee as a
                    Where ID in (Select managerId From CTE)
                ";
    }
}
