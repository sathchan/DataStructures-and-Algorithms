using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{//1 2 2 3 3 
    public class RemoveDuplicatesInList
    {
        public ListNode Main(ListNode head)
        {
            ListNode current = head;
            while (current != null && current.next != null)
            {
                if (current.next.val == current.val)
                {
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }
            }
            return head;
        }
    }
}
