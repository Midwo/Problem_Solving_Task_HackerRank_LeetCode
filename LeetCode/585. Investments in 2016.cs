using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_585
    {
        ////(585.) Investments in 2016 (MEDIUM)
        string SqlQuery =
                @"
                     Select 
                         ROUND(SUM(a.tiv_2016), 2) as tiv_2016 
                     From
                     (
                         Select 
                             tiv_2016,
                             CONCAT(lat, lon) as latlon
                         From Insurance
                         Where tiv_2015 in 
                             (
                                 Select
                                     tiv_2015
                                     --Count(*) as howMany
                                 From Insurance 
                                 Group by tiv_2015
                                 Having Count(*) > 1
                             )
                     ) a
                     Where a.latlon in 
                     (
                         Select
                             b.latlon
                             --Count(*)
                         From
                         (
                             Select 
                                 CONCAT(lat, lon) as latlon
                             From Insurance 
                         ) b
                         Group by b.latlon
                         Having Count(*) = 1
                     )
                ";
    }
}
