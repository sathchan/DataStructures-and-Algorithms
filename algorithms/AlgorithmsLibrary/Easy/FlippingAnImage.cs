using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    /*
            FlippingAnImage obj = new FlippingAnImage();
            int[] input2 = new int[] { 1, 1, 0, 0 };
            int[] input3 = new int[] { 1, 0, 0, 1 };
            int[] input4 = new int[] { 0, 1, 1, 1 };
            int[] input5 = new int[] { 1, 0, 1, 0 };

            int[][] input = new int[][]
            {
                input2, input3, input4, input5
            };
         */
    public class FlippingAnImage
    {
        public int[][] Main(int[][] A)
        {
            var flippedImage = FlipImage(A);
            return InvertImage(flippedImage);
        }

        public int[][] FlipImage(int[][] A)
        {
            foreach (var item in A)
            {
                for (int i = 0, j = item.Length-1; i < item.Length && j >= i; i++, j--)
                {
                    int temp = item[i];
                    item[i] = item[j];
                    item[j] = temp;
                }
            }

            return A;
        }

        public int[][] InvertImage(int[][] A)
        {
            foreach (var item in A)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    item[i] = 1 - item[i];
                }
            }

            return A;
        }
    }
}
