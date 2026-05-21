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
    public ListNode SortList(ListNode head) 
    {
        return MergeSort(head);
    }

    ListNode MergeSort(ListNode linkedList)
    {
        if (linkedList?.next == null)
        {
            return linkedList;
        }

        var head = linkedList;
        ListNode left = head;
        ListNode right = head;    

        while (right.next?.next != null)
        {
            left = left.next;
            right = right.next.next;       
        }

        right = left.next;
        left.next = null;

        right = MergeSort(right);
        left = MergeSort(head);

        return Merge(left, right);
    }
    ListNode Merge(ListNode left, ListNode right)
    {
        ListNode head = new ListNode();
        var headNext = head; 

        while (left != null && right != null)
        {       

            if (left.val <= right.val)
            {
                headNext.next = left;
                left = left.next;
            }
            else
            {
                headNext.next = right;
                right = right.next;
            }
            headNext = headNext.next;       
        }

        while (left != null)
        {
            headNext.next = left;
            headNext = headNext.next;
            left = left.next;       

        }
        while (right != null)
        {
            headNext.next = right;
            headNext = headNext.next;
            right = right.next;        
        }    
        return head.next;
    }
}