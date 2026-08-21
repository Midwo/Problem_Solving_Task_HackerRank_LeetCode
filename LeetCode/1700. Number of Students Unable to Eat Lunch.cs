using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1700
    {
        ////(1700.) Number of Students Unable to Eat Lunch (EASY)
        public int CountStudents(int[] students, int[] sandwiches)
        {
            Queue<int> lineStudents = new Queue<int>(students);

            foreach (int sandwich in sandwiches) 
            {
                int countStudents = lineStudents.Count;

                for (int i = 0; i < countStudents; i++) 
                { 
                    int tempWhatNeed = lineStudents.Dequeue();

                    if(tempWhatNeed == sandwich)
                    {
                        break;
                    }
                    else
                    {
                        lineStudents.Enqueue(tempWhatNeed);
                    }
                }

                if (countStudents == lineStudents.Count)
                {
                    return countStudents;
                }
            }

            return 0;
        }
    }
}
