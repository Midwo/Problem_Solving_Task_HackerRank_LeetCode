using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0152
    {
        ////152. The Report (MEDIUM)
        //string SqlQuery =
        //    @"
        //        SELECT
        //            CASE    
        //                when GRADE >= 8 then NAME
        //            end as NAME
        //            ,[Grade]
        //            ,[Marks]
        //        FROM 
        //           (
        //            SELECT [ID]
        //                  ,[Name]
        //                  ,[Marks]
        //                  ,(SELECT TOP 1 GRADE FROM Grades WHERE [Marks] >= Min_Mark and [Marks] <= Max_Mark) as Grade
        //            FROM [Students] as A

        //            ) as A1
        //        order by [GRADE] desc, [NAME]
        //    ";
    }
}
