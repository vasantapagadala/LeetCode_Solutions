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
    public ListNode MergeKLists(ListNode[] lists) {
        PriorityQueue<ListNode, int> pq = new PriorityQueue<ListNode, int>();
        foreach (var head in lists) {
            if (head != null) {
                pq.Enqueue(head, head.val);
            }
        }
        var temp = new ListNode();
        var curr = temp;
        while (pq.Count > 0) {
            var node = pq.Dequeue();
            curr.next = node;
            curr = curr.next;
            if (node.next != null) {
                pq.Enqueue(node.next, node.next.val);
            }
        }
        return temp.next;
    }
}