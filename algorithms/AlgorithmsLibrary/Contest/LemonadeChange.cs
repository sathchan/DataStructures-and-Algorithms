using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class LemonadeChange
    {
        public bool Main(int[] bills)
        {
            int change5 = 0, change10 = 0, change20 = 0;
            foreach (var item in bills)
            {
                if (item == 5) change5++;
                if (item == 10) change10++;
                if (item == 20) change20++;

                var changeRequired = item - 5;
                if (changeRequired != 0)
                {
                    if (changeRequired == 5 && change5 >= 1) { change5--; continue; }
                    if (changeRequired == 10 && change10 >= 1) { change10--; continue; }
                    if (changeRequired == 10 && change5 >= 2) { change5 -= 2; continue; }
                    if (changeRequired == 15 && change10 >= 1 && change5 >= 1) { change10--; change5--; continue; }
                    if (changeRequired == 15 && change5 >= 3) { change5 -= 3; continue; }

                    return false;
                }
            }

            return true;
        }
    }
}
