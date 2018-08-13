using System;
using AlgorithmsLibrary;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(1);
            ListNode l2 = new ListNode(2);
            ListNode l7 = new ListNode(6);
            ListNode l3 = new ListNode(3);
            ListNode l4 = new ListNode(4);
            ListNode l5 = new ListNode(5);
            ListNode l6 = new ListNode(6);
            

            l1.next = l2; l2.next = l7; l7.next = l3;
            l3.next = l4; l4.next = l5; l5.next = l6;

            RemoveLinkedElements obj = new RemoveLinkedElements();
            var result = obj.Main(l1, 6);

            Console.WriteLine(result.ToString());
            Console.ReadLine();

            //int[,] array2Da = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 0, 8, 9 } };
            //var result = obj.Main(10, new int[] { 2, 4 }, new int[] { 3, 2 }); //Car Fleet: Expected 1
            //var result = obj.FindReplaceString("vyeqmeyggv", new int[] { 4, 0, 7}, new string[] { "mey", "vye", "ggv" }, new string[] { "bq", "aa", "aqq" });
        }
    }
}

