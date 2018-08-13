using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class Workingwith2DArray
    {
        public int[] Main(int[,] nums)
        {
            //Row Sum
            int rowSum = 0;
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    rowSum += nums[i, j];
                }
            }

            //Column Sum
            int colSum = 0;
            for (int j = 0; j < nums.GetLength(1); j++)
            {
                for (int i = 0; i < nums.GetLength(0); i++)
                {
                    colSum += nums[i, j];
                }
            }

            //Diagonal Sum
            int diagSum = 0;
            for (int i = 0, j = 0; i < nums.GetLength(0) && j < nums.GetLength(1); i++, j++)
            {
                if (i == j) diagSum += nums[i, j];
            }

            // AntiDiagonal Sum
            int adiagSum = 0;
            for (int i = 0, j = nums.GetLength(1) - 1; i < nums.GetLength(0) && j > 0; i++, j--)
            {
                adiagSum += nums[i, j];                
            }


            /*
             * 1 2 3
             * 4 5 6
             * 0 8 9
             * RowSum = 38
             * ColSum = 38
             * DiagSum = 15
             * ADiagSum =8
             * */


            return new int[] { rowSum, colSum, diagSum, adiagSum };
        }
    }
}
