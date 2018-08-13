using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class RomanToInteger
    {
        public int Main(string romanNum)
        {
            Dictionary<char, int> romanRef = new Dictionary<char, int>();
            romanRef.Add('I', 1);
            romanRef.Add('V', 5);
            romanRef.Add('X', 10);
            romanRef.Add('L', 50);
            romanRef.Add('C', 100);
            romanRef.Add('D', 500);
            romanRef.Add('M', 1000);

            char[] numArray = romanNum.ToCharArray();
            int num = 0; int previousNum = 0;

            for (int i = 0; i < numArray.Length; i++)
            {
                if (romanRef.ContainsKey(numArray[i]))
                {
                    int dicValue = 0;
                    romanRef.TryGetValue(numArray[i], out dicValue);

                    if (previousNum < dicValue && i != 0)
                    {
                        int temp = dicValue - previousNum;
                        num -= previousNum;
                        num += temp;
                    }
                    else
                    {
                        num += dicValue;
                    }

                    previousNum = dicValue;
                }
            }

            return num;
        }
    }
}
