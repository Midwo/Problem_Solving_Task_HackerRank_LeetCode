using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_874
    {
        ////(874.) Walking Robot Simulation (MEDIUM)
        public int RobotSim(int[] commands, int[][] obstacles)
        {
            int lengthObstacles = obstacles.Length;
            int maxSquaredEuclideanDistance = 0;
            int[] actualPosition = [0, 0];
            //NSWE Table
            int[][] nsweTable = [[0,1],[1,0],[0,-1],[-1,0]];
            int currTurn = 0;

            HashSet<(int,int)> checkCollision = new HashSet<(int, int)>();

            for (int i = 0; i < obstacles.Length; i++)
            {
                checkCollision.Add((obstacles[i][0], obstacles[i][1]));
            }

            for (int index = 0; index < commands.Length; index++)
            {
                int currCommand = commands[index];

                if(currCommand == -1)
                {
                    if(currTurn == 3)
                    {
                        currTurn = 0;
                    }
                    else
                    {
                        currTurn++;
                    }
                }else if (currCommand == -2)
                {
                    if(currTurn == 0)
                    {
                        currTurn = 3;
                    }
                    else
                    {
                        currTurn--;
                    }
                }
                else
                {
                    for (int walking = 0; walking < currCommand; walking++)
                    {
                        actualPosition[0] += nsweTable[currTurn][0];
                        actualPosition[1] += nsweTable[currTurn][1];

                        if (checkCollision.Contains((actualPosition[0], actualPosition[1])))
                        { 
                            actualPosition[0] -= nsweTable[currTurn][0];
                            actualPosition[1] -= nsweTable[currTurn][1];
                            break;
                        }
                        maxSquaredEuclideanDistance = Math.Max(maxSquaredEuclideanDistance, (int)(Math.Pow(actualPosition[0], 2) + Math.Pow(actualPosition[1], 2)));
                    }
                }
            }

            return maxSquaredEuclideanDistance;
        }
    }
}
