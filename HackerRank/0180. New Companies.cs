using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0180
    {
        ////180. New Companies (MEDIUM)
        //string SqlQuery =
        //@"
        //    SELECT 
        //        company_code,
        //        founder,
        //        lead_manager,
        //        senior_manager,
        //        manager,
        //        employee
        //     From 
        //     (
        //        SELECT 
        //            a.company_code,
        //            a.founder,
        //            b.lead_manager,
        //            c.senior_manager,
        //            d.manager,
        //            e.employee
        //        FROM Company as a
        //        LEFT JOIN 
        //        (
        //            SELECT 
        //                [company_code], 
        //                COUNT(distinct [lead_manager_code]) as lead_manager, 
        //                [lead_manager_code]
        //            FROM [Lead_Manager]
        //            GROUP BY [company_code], [lead_manager_code]
        //        ) as b 
        //     ON a.company_code = b.[company_code]
        //     LEFT JOIN
        //     (
        //        SELECT 
        //            [company_code], COUNT(distinct [senior_manager_code]) as senior_manager
        //            FROM [Senior_Manager]
        //            GROUP BY [company_code]
        //     ) as c
        //     ON a.[company_code] = c.[company_code]
        //     LEFT JOIN 
        //     (
        //        SELECT 
        //           [company_code], COUNT(distinct [manager_code]) as manager
        //           FROM [Manager]
        //           GROUP BY [company_code]
        //     ) as d
        //     ON a.[company_code] = d.[company_code]
        //     LEFT JOIN 
        //     (
        //        SELECT
        //            [company_code], COUNT(distinct [employee_code]) as employee
        //            FROM [Employee]
        //            GROUP BY [company_code]
        //     ) as e
        //     ON a.[company_code] = e.[company_code]  
        //     ) as x
        //     order by company_code
        //";
    }
}
