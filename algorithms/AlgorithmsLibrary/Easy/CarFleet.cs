using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class CarFleet
    {
        public int Main(int target, int[] position, int[] speed)
        {
            Dictionary<int, int> fleets = new Dictionary<int, int>();
            for (int i = 0; i < position.Length; i++)
            {
                int fleetPos = speed[i] + position[i];
                if (fleetPos <= target && !fleets.ContainsKey(fleetPos))
                {
                    fleets.Add(fleetPos, fleetPos);
                }
            }

            return fleets.Count;
        }
    }
}
