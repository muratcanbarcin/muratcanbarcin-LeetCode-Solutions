/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
class Solution {
    public ListNode modifiedList(int[] nums, ListNode head) {
        
        boolean[] toDelete = new boolean[100001];
        
        for (int num : nums) {
            toDelete[num] = true;
        }
        
        ListNode dummy = new ListNode(0, head);
        ListNode prev = dummy;
        ListNode current = head;
        
        while (current != null) {
            if (toDelete[current.val]) {
                prev.next = current.next;
            } else {
                prev = current;
            }
            current = current.next;
        }
        
        return dummy.next;
    }
}