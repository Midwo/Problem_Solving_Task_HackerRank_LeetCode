using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0157
    {
        ////157. SQL Project Planning (MEDIUM)
        //string SqlQuery =
        //@"
        //    with start_end as 
        //    (
        //        select *, 
        //            lag(end_date) over(order by start_date) as prev_end, 
        //            lead(start_date) over(order by start_date) as next_start from projects
        //    )
        //    -- SELECT * FROM start_end
        //    ,

        //    start1 as 
        //    (
        //        select start_date, row_number() over(order by start_date) as rn 
        //        from start_end 
        //        where (prev_end != start_date or prev_end is Null)SQL Project Planning
        //    )
        //    --SELECT * FROM start1
        //    ,

        //        end1 as 
        //    (
        //        select end_date,row_number() over(order by start_date) as rn 
        //        from start_end where (next_start != end_date or next_start is Null)
        //    )
        //    --SELECT * FROM end1
        //    ,

        //        final as 
        //    (
        //        select 
        //            a.start_date,
        //            b.end_date, 
        //            datediff(day,a.start_date,b.end_date) as duration 
        //        from start1 a join end1 b on a.rn = b.rn
        //    )

        //    select start_date, end_date from final order by duration, start_date;
        //";


    }
}
