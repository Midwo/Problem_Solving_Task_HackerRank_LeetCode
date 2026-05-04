using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2126
    {
        ////(2126.) Destroying Asteroids (MEDIUM)
        public bool AsteroidsDestroyed(int mass, int[] asteroids)
        {
            long currMass = mass;
            PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
            foreach (var massAsteroid in asteroids)
            {
                if (currMass >= massAsteroid)
                    currMass += massAsteroid;
                else
                {
                    queue.Enqueue(massAsteroid, massAsteroid);
                }
            }

            while (queue.Count > 0)
            {
                int temp = queue.Dequeue();
                if (currMass >= temp)
                    currMass += temp;
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
