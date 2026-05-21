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
    public ListNode SortList(ListNode head) {
        if(head == null || head.next == null) {
            return head;
        }

        ListNode mid = GetMid(head);
        ListNode right = mid.next;
        mid.next = null;

        ListNode l = SortList(head);
        ListNode r = SortList(right);

        return Merge(l,r);
    }

    public ListNode GetMid(ListNode node) {
        ListNode slow = node;
        ListNode fast = node.next;

        while(fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }

        return slow;
    }

    public ListNode Merge(ListNode left, ListNode right) {
        ListNode dummy = new ListNode();
        ListNode cur = dummy;        

        while(left != null && right !=null) {
            if(left.val < right.val) {
                cur.next = left;
                left = left.next;
            } else {
                cur.next = right;
                right = right.next;
            }
            cur = cur.next;
        }

        cur.next = left == null ? right : left;

        return dummy.next;
    }
}