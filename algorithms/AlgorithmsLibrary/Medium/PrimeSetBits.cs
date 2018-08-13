using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class PrimeSetBits
    {
        public int Main(int L, int R)
        {
            int noOfPrimes = 0;

            for (int i = L; i <= R; i++)
            {
                var binaryNum = Convert.ToString(i, 2);
                var setBitCounter = 0;
                foreach (var item in binaryNum.ToCharArray())
                {
                    if (item == '1') setBitCounter++;
                }

                if (IsPrime(setBitCounter)) noOfPrimes++;
            }

            return noOfPrimes;
        }

        public bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
