using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0006
    {
        public List<int> gradingStudents(List<int> grades)
        {
            List<int> ListGrading = new List<int>();

            foreach (int i in grades)
            {
                if (i < 38)
                {
                    ListGrading.Add(i);
                }
                else
                {
                    double x1;
                    x1 = i / 5;
                    int z1 = (int)x1;
                    int y1 = i % 5;
                    // ListGrading.Add(z1);
                    // ListGrading.Add(y1);
                    if (y1 >= 3)
                    {
                        ListGrading.Add((z1 + 1) * 5);
                    }
                    else
                    {
                        ListGrading.Add(i);
                    }
                }
            }
            return ListGrading;
        }

    }
}
