using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1661
    {
        ////(1661.) Average Time of Process per Machine (EASY)
        string SqlQuery =
                @"
                    With CTE AS
                    (
                        Select
                            machine_id,
                            process_id,
                            timestamp as start
                        From Activity 
                        Where activity_type = 'start'
                    )
                    
                    Select 
                        a.machine_id,
                        Round(AVG(timestamp - start),3) as processing_time 
                    FROM CTE as a
                    Left Join Activity as b
                    ON a.machine_id = b.machine_id and a.process_id  = b.process_id 
                    where activity_type = 'end'
                    Group by a.machine_id   
                ";
    }
}
