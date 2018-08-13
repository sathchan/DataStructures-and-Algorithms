using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class TransposeMatrix
    {

        public int[][] Transpose(int[][] A)
        {
            int i, j, n = A.Length, m = A[0].Length;
            int[,] ans = new int[m, n];
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    ans[i,j] = A[j][i];
                }
            }

            int[][] result = A;
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    result[i][j] = ans[j,i];
                }
            }
            
            return result;
        }        
    }
}
