/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
      ListNode temp = new ListNode(0);
      ListNode curr = temp;
      int c = 0;
      while (l1 != null || l2 != null || c != 0)
      {
        int x = (l1 != null) ? l1.val : 0;
        int y = (l2 != null) ? l2.val : 0;
        int sum = c + x + y;
        c = sum / 10;
        curr.next = new ListNode(sum % 10);
        curr = curr.next;
        if(l1 != null)
            l1 = l1.next;
        if(l2 != null)
            l2 = l2.next;
      }   
      return temp.next;
    }
}