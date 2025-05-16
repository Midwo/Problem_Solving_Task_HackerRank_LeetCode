using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1484
    {
        ////(1484.) Group Sold Products By The Date (EASY)
        string SqlQuery =
                @"
                    With my_CTE as 
                    (
                        Select
                            distinct sell_date,
                            product  
                        From Activities 
                    )
                    
                    Select 
                        sell_date,
                        Count(*) as num_sold , 
                        String_AGG(product, ',') as products   
                    From my_CTE
                    Group by sell_date     
                ";
    }
}
