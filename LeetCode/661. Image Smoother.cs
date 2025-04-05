using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_661
    {
        ////(661.) Image Smoother (EASY)
        public int[][] ImageSmoother(int[][] img)
        {
            int count = img.Length;
            int length = img[0].Length;
            int[][] result = new int[count][];
            if(count == 0)
            {
                return img;
            }
            int currIndexCount = 0;
            int currIndexLength = 0;
            result[currIndexCount] = new int[length];
            while (currIndexLength < length)
            {
                if (currIndexLength == 0)
                {
                    if(count > 1)
                    {
                        if (currIndexLength+1 < length)
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength] + img[currIndexCount + 1][currIndexLength]+ img[currIndexCount][currIndexLength+1]+ img[currIndexCount + 1][currIndexLength+1])/4;
                        }
                        else
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength] + img[currIndexCount + 1][currIndexLength])/2;
                        }
                    }
                    else
                    {
                        if (currIndexLength < length-1)
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength] + img[currIndexCount][currIndexLength + 1]) / 2;
                        }
                        else
                        {
                            if(length == 1 && count == 1)
                            {
                                return img;
                            }
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength]);
                        }
                    }
                }
                else if (currIndexLength == length-1)
                {
                    if (count > 1)
                    {
                        if (length > 1)
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength] + img[currIndexCount+1][currIndexLength]+ img[currIndexCount][currIndexLength-1]+ img[currIndexCount+1][currIndexLength-1])/4;
                        }
                        else
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength]+ img[currIndexCount+1][currIndexLength])/2;
                        }
                    }
                    else
                    {
                        if (length > 1)
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength]+ img[currIndexCount][currIndexLength-1])/2;
                        }
                        else
                        {
                            result[currIndexCount][currIndexLength] = img[currIndexCount][currIndexLength];
                        }
                    }
                }
                else
                {
                    if (count > 1)
                    {
                        if (length > 1)
                        { 
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength] + img[currIndexCount+1][currIndexLength]+ img[currIndexCount][currIndexLength+1] + img[currIndexCount+1][currIndexLength + 1]+ img[currIndexCount + 1][currIndexLength-1]+ img[currIndexCount][currIndexLength-1]) /6;
                        }
                        else
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength] + img[currIndexCount+1][currIndexLength])/2;
                        }
                    }
                    else
                    {
                        if (length > 1)
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength]+ img[currIndexCount][currIndexLength-1]+ img[currIndexCount][currIndexLength+1])/3;
                        }
                        else
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength]);
                        }
                    }
                }
                currIndexLength++;
            }
            currIndexCount++;
            while (currIndexCount < count - 1)
            {
                result[currIndexCount] = new int[length];
                currIndexLength = 0;
                while (currIndexLength < length)
                {
                    if (currIndexLength == 0)
                    {
                        if (length > 1)
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength] + img[currIndexCount+1][currIndexLength]+ img[currIndexCount-1][currIndexLength]+ 
                                img[currIndexCount -1][currIndexLength+1]+ img[currIndexCount][currIndexLength+1]+ img[currIndexCount+1][currIndexLength+1])/6;
                        }
                        else
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength] + img[currIndexCount-1][currIndexLength] + img[currIndexCount+1][currIndexLength]) / 3;
                        }
                    }
                    else if( currIndexLength == length-1)
                    {
                        if (length > 1)
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength]+ img[currIndexCount-1][currIndexLength]+ img[currIndexCount+1][currIndexLength]
                                + img[currIndexCount-1][currIndexLength-1]+ img[currIndexCount][currIndexLength-1]+ img[currIndexCount+1][currIndexLength-1])/6;
                        }
                        else
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength]+ img[currIndexCount-1][currIndexLength]+ img[currIndexCount+1][currIndexLength])/3;
                        }
                    }
                    else
                    {
                        if (length > 1)
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength] + img[currIndexCount-1][currIndexLength] + img[currIndexCount+1][currIndexLength]+
                                img[currIndexCount-1][currIndexLength-1] + img[currIndexCount][currIndexLength-1] + img[currIndexCount+1][currIndexLength-1]+
                                img[currIndexCount-1][currIndexLength+1] + img[currIndexCount+1][currIndexLength+1]+ img[currIndexCount][currIndexLength+1]) / 9;
                        }
                    }
                    currIndexLength++;
                }
            
                currIndexCount++;
            }
            while (currIndexCount == count - 1 && currIndexCount > 0)
            {
                result[currIndexCount] = new int[length];
                currIndexLength = 0;
                while (currIndexLength < length)
                {
                    if(currIndexLength == 0)
                    {
                        if(length > 1)
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength]+ img[currIndexCount-1][currIndexLength]+
                                img[currIndexCount][currIndexLength+1]+ img[currIndexCount-1][currIndexLength+1])/4;
                        }
                        else
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength]+ img[currIndexCount-1][currIndexLength])/2;
                        }
                    }
                    else if (currIndexLength == length-1)
                    {
                        if (length > 1)
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength]+ img[currIndexCount-1][currIndexLength]+
                                img[currIndexCount][currIndexLength-1]+ img[currIndexCount-1][currIndexLength-1])/4;
                        }
                        else
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength]+ img[currIndexCount-1][currIndexLength])/2;
                        }
                    }
                    else
                    {
                        if(length > 1)
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength]+ img[currIndexCount][currIndexLength+1]+
                                img[currIndexCount][currIndexLength-1]+ img[currIndexCount-1][currIndexLength-1] + img[currIndexCount-1][currIndexLength]+
                                img[currIndexCount-1][currIndexLength+1]) /6;
                        }
                        else
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength]+ img[currIndexCount-1][currIndexLength])/2;
                        }
                    }
                    currIndexLength++;
                }
                currIndexCount++;
            }

            return result;
        }
    }
}
