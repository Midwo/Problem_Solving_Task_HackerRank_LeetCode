using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2356
    {
        ////(2356.) Number of Unique Subjects Taught by Each Teacher (EASY)
        string SqlQuery =
                @"
                    Select 
                        teacher_id,
                        Count(distinct subject_id) as cnt 
                    From Teacher 
                    Group by teacher_id
                ";
    }
}
