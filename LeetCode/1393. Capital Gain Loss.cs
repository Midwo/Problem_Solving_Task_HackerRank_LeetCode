using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1393
    {
        ////(1393.) Capital Gain/Loss (MEDIUM)
        string SqlQuery =
            @"
                    Select
                        Distinct(a.stock_name)
                        ,(c.SumSell - b.SumBuy) as capital_gain_loss 
                    From Stocks a 
                        join (Select
                        stock_name
                        ,SUM(price) as SumBuy
                    From Stocks
                    Where operation = 'Buy'
                    GROUP BY stock_name) b
                    ON a.stock_name = b.stock_name
                        join (Select
                        stock_name
                        ,SUM(price) as SumSell
                    From Stocks
                    Where operation = 'Sell'
                    GROUP BY stock_name) c
                    ON a.stock_name = c.stock_name
            ";
    }
}
