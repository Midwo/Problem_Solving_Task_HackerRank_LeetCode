using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1683
    {
        ////(1683.) Invalid Tweets (EASY)
        string SqlQuery =
                @"
                    Select 
                        tweet_id 
                    From Tweets 
                    Where Length(content) > 15        
                ";
    }
}
