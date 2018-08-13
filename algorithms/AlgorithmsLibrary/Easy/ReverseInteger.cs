using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AlgorithmsLibrary
{
    public class ReverseInteger
    {
        public int MainMethod(int num)
        {
            int temp = num;
            int counter = 0, reversedInt = 0;
            while (temp != 0)
            {
                int x = temp % 10;
                temp /= 10;

                reversedInt += x * Convert.ToInt32(Math.Pow(10, Math.Abs(num).ToString("0").ToCharArray().Length - counter - 1));

                counter++;
            }

            return reversedInt * Math.Sign(num);
        }
    }
}
