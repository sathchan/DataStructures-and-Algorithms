using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class RemoveLinkedElements
    {
        public ListNode Main(ListNode head, int val)
        {
            if (head == null) return null;
            ListNode pointer = head;
            while (pointer.next != null)
            {
                if (pointer.next.val == val) pointer.next = pointer.next.next;
                else pointer = pointer.next;
            }
            return head.val == val ? head.next : head;
        }
    }
}
