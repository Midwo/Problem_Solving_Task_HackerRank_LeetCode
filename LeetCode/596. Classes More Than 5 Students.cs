using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_596
    {
        ////(596.) Classes More Than 5 Students (EASY)

        ////T-SQL query CODE - MS SQL */

        //Select
        //    [class]
        //FROM(
        //     Select
        //        [class],
        //        COUNT([class]) as [howMany]
        //     From Courses
        //     Group by[class] ) as a
        //Where[howMany] >= 5


        ////OR 
        
        //Select
        //    [class]
        //FROM Courses
        //GROUP BY class
        //HAVING COUNT(DISTINCT student) >= 5

    }
}
