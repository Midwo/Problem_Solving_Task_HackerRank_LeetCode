using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1329
    {
        ////(1329.) Sort the Matrix Diagonally (MEDIUM)
        public int[][] DiagonalSort(int[][] mat)
        {
            ////7ms, Beats: 74.00%
            int height = mat.Length;
            int width = mat[0].Length;


            for (int j = 0; j < width; j++)
            {
                int indexX = j;
                int indexY = 0;
                List<int> list = new List<int>();
                while(indexX < width && indexY < height)
                {
                    list.Add(mat[indexY++][indexX++]);
                }
                indexX = j;
                indexY = 0;
                list.Sort();
                int indexlist = 0;
                while (indexX < width && indexY < height)
                {
                    mat[indexY++][indexX++] = list[indexlist++];
                }
            }

            for (int i = 1; i < height; i++)
            {
                int indexX = 0;
                int indexY = i;
                List<int> list = new List<int>();
                while (indexX < width && indexY < height)
                {
                    list.Add(mat[indexY++][indexX++]);
                }
                indexX = 0;
                indexY = i;
                int indexlist = 0;
                list.Sort();
                while (indexX < width && indexY < height)
                {
                    mat[indexY++][indexX++] = list[indexlist++];

                }

            }

            return mat;

            ////17ms, Beats: 10.00%
            //int height = mat.Length;
            //int width = mat[0].Length;

            //PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();

            //for (int j = 0; j < width; j++)
            //{
            //    int indexX = j;
            //    int indexY = 0;
            //    priorityQueue.Enqueue(mat[indexY][indexX], mat[indexY++][indexX++]);
            //    while (indexX < width && indexY < height)
            //    {
            //        priorityQueue.Enqueue(mat[indexY][indexX], mat[indexY++][indexX++]);

            //    }
            //    indexX = j;
            //    indexY = 0;
            //    mat[indexY++][indexX++] = priorityQueue.Dequeue();
            //    while (indexX < width && indexY < height)
            //    {
            //        mat[indexY++][indexX++] = priorityQueue.Dequeue();
            //    }
            //}

            //for (int i = 1; i < height; i++)
            //{
            //    int indexX = 0;
            //    int indexY = i;
            //    priorityQueue.Enqueue(mat[indexY][indexX], mat[indexY++][indexX++]);
            //    while (indexX < width && indexY < height)
            //    {
            //        priorityQueue.Enqueue(mat[indexY][indexX], mat[indexY++][indexX++]);
            //    }
            //    indexX = 0;
            //    indexY = i;
            //    mat[indexY++][indexX++] = priorityQueue.Dequeue();
            //    while (indexX < width && indexY < height)
            //    {
            //        mat[indexY++][indexX++] = priorityQueue.Dequeue();

            //    }

            //}

            //return mat;


        }
    }
}
