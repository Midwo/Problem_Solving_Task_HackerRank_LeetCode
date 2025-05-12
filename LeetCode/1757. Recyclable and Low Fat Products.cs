using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1757
    {
        ////(1757.) Recyclable and Low Fat Products (EASY)
        string SqlQuery =
            @"
                    Select 
                        product_id  
                    From Products 
                    Where low_fats = 'Y' and recyclable = 'Y'
                ";

    }
}
