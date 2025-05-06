using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1148
    {
        ////(1148.) Article Views I (EASY)
        string SqlQuery =
            @"
                    WITH Views_CTE
                    AS 
                    (
                        Select 
                            article_id,
                            author_id,
                            viewer_id 
                        From Views
                        Where author_id = viewer_id
                    )

                    Select 
                        DISTINCT a.author_id as id
                    From Views_CTE as a
                ";

    }
}
