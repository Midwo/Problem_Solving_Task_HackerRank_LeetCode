using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1477
    {
        ////(1477.) Find Two Non-overlapping Sub-arrays Each With Target Sum (MEDIUM)
        public int MinSumOfLengths(int[] arr, int target)
        {
            int lenght = arr.Length;
            int[] bestLeft = new int[lenght];
            int[] bestRight = new int[lenght];

            int sum = 0;
            int lastCorrectIndexSum = 0;
            int bestLenght = 0;

            for (int currIndex = 0; currIndex < lenght; currIndex++) 
            { 
                sum += arr[currIndex];

                if (sum > target)
                {
                    while(lastCorrectIndexSum < currIndex)
                    {
                        sum -= arr[lastCorrectIndexSum++];
                        if(sum < target)
                            break;
                        else if(sum == target)
                        {
                            int currLenght = currIndex - lastCorrectIndexSum + 1;
                            if (bestLenght == 0)
                                bestLenght = currLenght;
                            bestLenght = Math.Min(bestLenght, currLenght);
                        }
                    }
                }
                else if (sum == target)
                {
                    int currLenght = currIndex - lastCorrectIndexSum + 1;
                    if (bestLenght == 0)
                        bestLenght = currLenght;
                    bestLenght = Math.Min(bestLenght, currLenght);
                }

                bestLeft[currIndex] = bestLenght;
            }

            if (bestLeft[lenght - 1] == 0)
                return -1;

            sum = 0;
            lastCorrectIndexSum = lenght-1;
            bestLenght = 0;

            for (int currIndex = lenght-1; currIndex >= 0; currIndex--)
            {
                sum += arr[currIndex];

                if (sum > target)
                {
                    while (lastCorrectIndexSum > currIndex)
                    {
                        sum -= arr[lastCorrectIndexSum--];
                        if (sum < target)
                            break;
                        else if (sum == target)
                        {
                            int currLenght = lastCorrectIndexSum + 1 - currIndex;
                            if (bestLenght == 0)
                                bestLenght = currLenght;
                            bestLenght = Math.Min(bestLenght, currLenght);
                        }
                    }
                }
                else if (sum == target)
                {
                    int currLenght = lastCorrectIndexSum + 1 - currIndex;
                    if (bestLenght == 0)
                        bestLenght = currLenght;
                    bestLenght = Math.Min(bestLenght, currLenght);
                }

                bestRight[currIndex] = bestLenght;
            }

            int minSumOfLengths = int.MaxValue;

            for (int index = 0; index < lenght-1; index++)
            {
                if (bestLeft[index] > 0 && bestRight[index + 1] > 0)
                    minSumOfLengths = Math.Min(minSumOfLengths, bestRight[index + 1] + bestLeft[index]);
                else if (bestRight[index + 1] == 0)
                    break;
            }

            return minSumOfLengths == int.MaxValue ? -1 : minSumOfLengths;
        }
    }
}
