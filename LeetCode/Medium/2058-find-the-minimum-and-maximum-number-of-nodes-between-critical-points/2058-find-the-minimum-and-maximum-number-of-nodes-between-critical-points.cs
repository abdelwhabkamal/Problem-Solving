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
    public int[] NodesBetweenCriticalPoints(ListNode head) {
        int[] res = [-1,-1];
        int indx = 1;
        int prev = 0;
        int first = 0;
        int min = int.MaxValue;
        while(head.next.next !=  null){
            if((head.next.val > head.val && head.next.val > head.next.next.val)
            || (head.next.val < head.val && head.next.val < head.next.next.val)){
                if(first == 0){
                    first = indx;
                    prev = indx;
                }
                else{
                    min = Math.Min(min, indx - prev);
                    prev = indx; 
                }
            }
            head = head.next;
            indx++;
        }
        if(first != prev) res = [min , prev - first];
        return res;
    }
}