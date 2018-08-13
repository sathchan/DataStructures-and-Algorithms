using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class RoboMove
    {
        public bool Main(string moves)
        {
            Dictionary<char, int> movesDict = new Dictionary<char, int>();
            movesDict.Add('L', 1);
            movesDict.Add('R', -1);
            movesDict.Add('U', 100);
            movesDict.Add('D', -100);

            int movesCount = 0;
            foreach (var move in moves)
            {
                int dictValue = 0;
                movesDict.TryGetValue(move, out dictValue);
                movesCount += dictValue;
            }

            return (movesCount == 0) ? true : false;
        }
    }
}
