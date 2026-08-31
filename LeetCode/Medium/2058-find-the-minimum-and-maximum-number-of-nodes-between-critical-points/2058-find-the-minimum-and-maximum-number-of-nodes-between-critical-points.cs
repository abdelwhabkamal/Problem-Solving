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
        List<int> points = new();
        while(head.next.next !=  null){
            if(head.next.val > head.val && head.next.val > head.next.next.val) points.Add(indx);
            else if(head.next.val < head.val && head.next.val < head.next.next.val) points.Add(indx);
            head = head.next;
            indx++;
        }
        int p = points.Count;
        if(p > 1){
            points.Sort();
            int min = int.MaxValue;
            for(int i = 0; i < p-1; i++){
                min = Math.Min(min, points[i+1] - points[i]);
            }
            res[0] = min;
            res[1] = points[p-1] - points[0];
        }
        return res;
    }
}