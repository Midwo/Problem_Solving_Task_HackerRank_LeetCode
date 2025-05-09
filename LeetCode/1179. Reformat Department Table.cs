using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1179
    {

        /////1179. Reformat Department Table (EASY)
        string SqlQuery =
            @"
                    Select 
                        id,
                        SUM(IIF(month ='Jan', Revenue, null)) as Jan_Revenue,
                        SUM(IIF(month ='Feb', Revenue, null)) as Feb_Revenue,
                        SUM(IIF(month ='Mar', Revenue, null)) as Mar_Revenue,
                        SUM(IIF(month ='Apr', Revenue, null)) as Apr_Revenue,
                        SUM(IIF(month ='May', Revenue, null)) as May_Revenue,
                        SUM(IIF(month ='Jun', Revenue, null)) as Jun_Revenue,
                        SUM(IIF(month ='Jul', Revenue, null)) as Jul_Revenue,
                        SUM(IIF(month ='Aug', Revenue, null)) as Aug_Revenue,
                        SUM(IIF(month ='Sep', Revenue, null)) as Sep_Revenue,
                        SUM(IIF(month ='Oct', Revenue, null)) as Oct_Revenue,
                        SUM(IIF(month ='Nov', Revenue, null)) as Nov_Revenue,
                        SUM(IIF(month ='Dec', Revenue, null)) as Dec_Revenue
                    From Department 
                    Group by id
                ";
    }
}
