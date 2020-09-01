using System;

namespace LeetCode {
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode (int x) { val = x; }
    }
    public class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Hello World!");
        }
        /*2.两数相加*/
        public ListNode AddTwoNumbers (ListNode l1, ListNode l2) {
            ListNode Result = null;
            int flag = 0;
            int data;
            while (l1 != null && l2 != null) {
                // int data = (l1.val + l2.val) > 10 ? (0) : (l1.val + l2.val);
                if (l1.val + l2.val > 10) {
                    data = 0;
                    flag = 1;
                } else {
                    data = l1.val + l2.val;
                }
                Result = new ListNode (data);
            }
            return Result;
        }
    }
}