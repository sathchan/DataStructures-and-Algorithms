using System;
using AlgorithmsLibrary;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {

            PartitionLabels obj = new PartitionLabels();
            var result = obj.Main("ababcbacadefegdehijhklij");

            Console.WriteLine(result.ToString());
            Console.ReadLine();

            //int[,] array2Da = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 0, 8, 9 } };
            //var result = obj.Main(10, new int[] { 2, 4 }, new int[] { 3, 2 }); //Car Fleet: Expected 1
            //var result = obj.FindReplaceString("vyeqmeyggv", new int[] { 4, 0, 7}, new string[] { "mey", "vye", "ggv" }, new string[] { "bq", "aa", "aqq" });
        }
    }
}

