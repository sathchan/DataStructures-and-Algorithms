using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsLibrary
{
    public class HandOfStraights
    {
        public bool Main(int[] hand, int W)
        {
            if (hand.Length % W != 0) return false;
            Dictionary<int, int> handDict = new Dictionary<int, int>();

            foreach (var item in hand)
            {
                if (!handDict.ContainsKey(item)) handDict.Add(item, 1);
                else
                {
                    var temp = 0;
                    handDict.TryGetValue(item, out temp);
                    handDict[item] = temp++;
                }
            }

            foreach (var item in handDict)
            {
                if (item.Value > W) return false;
            }

            return true;
        }

        public bool isNStraightHand(int[] hand, int W)
        {
            Dictionary<int, int> count = new Dictionary<int, int>();
            foreach (int card in hand)
            {
                if (!count.ContainsKey(card))
                    count.Add(card, 1);
                else
                {
                    var temp = 0;
                    count.TryGetValue(card, out temp);
                    count[card] = temp++;
                }                    
            }

            while (count.Count > 0)
            {
                int first = count.First().Key;
                for (int card = first; card < first + W; ++card)
                {
                    if (!count.ContainsKey(card)) return false;
                    int c = count[card];
                    if (c == 1) count.Remove(card);
                    else
                    {
                        var temp = 0;
                        count.TryGetValue(card, out temp);
                        count[card] = c - 1;
                    }                        
                }
            }

            return true;
        }
    }
}
