using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_550
    {
        ////(550.) Game Play Analysis IV (MEDIUM)
        string SqlQuery =
            @"
                    Select
                        Round(Count(b.player_id)*1.0/(Select Count(distinct player_id) from Activity),2) as fraction 
                    From
                    (
                        Select     
                            a.player_id, 
                            a.event_date,
                            a.Row_numberResult
                        From 
                        (
                            Select 
                                player_id, 
                                event_date,
                                Row_number () OVER (PARTITION BY player_id ORDER BY event_date) as Row_numberResult
                            From Activity
                        ) as a
                        Where a.Row_numberResult = 1
                    ) b
                    left join 
                    (
                        Select     
                            a.player_id, 
                            a.event_date,
                            a.Row_numberResult
                        From 
                        (
                            Select 
                                player_id, 
                                event_date,
                                Row_number () OVER (PARTITION BY player_id ORDER BY event_date) as Row_numberResult
                            From Activity
                        ) as a
                        Where a.Row_numberResult = 2
                    ) c
                    ON b.player_id = c.player_id
                    Where DateDiff(day, b.event_date, c.event_date) = 1
                ";
    }
}
