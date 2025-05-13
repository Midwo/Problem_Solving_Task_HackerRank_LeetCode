using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1280
    {
        ////(1280.) Students and Examinations (EASY)
        string SqlQuery =
            @"
                    With CTE AS 
                    (
                        Select
                            a.student_id,
                            a.student_name,
                            subject_name
                        From Students as a
                        CROSS JOIN Subjects 
                    )
                    
                    Select 
                        b.student_id, 
                        b.student_name,
                        b.subject_name,
                        Count(a.subject_name) as attended_exams 
                    From Examinations as a
                    right join CTE as b
                    ON a.student_id = b.student_id and a.subject_name = b.subject_name
                    Group by b.student_id, b.student_name, b.subject_name
                    order by b.student_id, b.subject_name    
                ";
    }
}
